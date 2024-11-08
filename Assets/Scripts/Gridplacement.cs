using System.Collections.Generic;
using Unity.VisualScripting;
using System;
using UnityEngine;

public class Gridplacement : MonoBehaviour
{
    [SerializeField] private GameObject[] yZero;
    [SerializeField] private GameObject[] yOne;
    [SerializeField] private GameObject[] yTwo;
    [SerializeField] private GameObject[] yThree;
    [SerializeField] private GameObject[] yFour;

    [SerializeField] private GameObject testingPrefab;

    [SerializeField] private List<GameObject[]> masterList = new List<GameObject[]>();


    void SpawnPrefab_Grid()
    {
        int z = 1;
        for (int j = 0; j < masterList.Count;)
        {
            GameObject[] row = masterList[masterList.Count - 1];
            if (masterList.Count > 0)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    System.Random rd = new System.Random();
                    int rand_num = rd.Next(0, 2);
                    if (rand_num == 1)
                    {
                        Instantiate(testingPrefab, new Vector3(i.ConvertTo<float>() + 0, 0, z + 0), Quaternion.identity);
                    }
                }
                z++;
                Debug.Log(z);
                Debug.Log("masterList size" + masterList[masterList.Count - 1]);
            }
            
        }
    }



    private void Start()
    {
        masterList.Add(yZero);
        masterList.Add(yOne);
        masterList.Add(yTwo);
        masterList.Add(yThree);
        masterList.Add(yFour);
        SpawnPrefab_Grid();
        Debug.Log($"masterList contains: {masterList.Count}");
    }

}
