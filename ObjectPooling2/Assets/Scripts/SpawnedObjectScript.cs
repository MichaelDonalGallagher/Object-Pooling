using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedObjectScript : MonoBehaviour
{
    int[] dummyData;

    private void Awake()
    {
        dummyData = new int[1000];

        for(int i = 0; i< dummyData.Length; i++)
        {
            dummyData[i] = i;
        }
    }

    private void OnCollisionEnter(Collision otherBody)
    {
        Destroy(gameObject);
    }
}
