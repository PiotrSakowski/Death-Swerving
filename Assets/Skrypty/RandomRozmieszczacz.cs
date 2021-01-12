using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRozmieszczacz : MonoBehaviour
{
    public GameObject pozycja1, pozycja2, pozycja3, pozycja4;
    int[] ToLoad = new int[] { 0, 1, 2, 3, 4 };
    
    
    void Start()
    {
        int RandomIndex = (int)System.Math.Min(ToLoad.Length - 1, Random.Range(0, ToLoad.Length));

        if(RandomIndex == 1)
            transform.position = pozycja1.transform.position;

        if (RandomIndex == 2)
            transform.position = pozycja2.transform.position;

        if (RandomIndex == 3)
            transform.position = pozycja3.transform.position;

        if (RandomIndex == 4)
            transform.position = pozycja4.transform.position;

        if (RandomIndex == 0)
            transform.position = pozycja1.transform.position;

        //Debug.Log("wylosowano" + RandomIndex);

    }
    
}
