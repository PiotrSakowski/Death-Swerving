using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObrazek : MonoBehaviour
{
    public GameObject Clue1, Clue2, Clue3, Clue4;
    public GameObject Floor1, Floor2, Floor3, Floor4;
    int[] ToLoad = new int[] { 0, 1, 2, 3, 4 };


    void Start()
    {
        int RandomIndex = (int)System.Math.Min(ToLoad.Length - 1, Random.Range(0, ToLoad.Length));

        if (RandomIndex == 1)
        {
            Clue1.SetActive(true);
            Floor1.SetActive(true);
        }
            

        if (RandomIndex == 2)
        {
            Clue2.SetActive(true);
            Floor2.SetActive(true);
        }
            

        if (RandomIndex == 3)
        {
            Clue3.SetActive(true);
            Floor3.SetActive(true);
        }
            

        if (RandomIndex == 4)
        {
            Clue4.SetActive(true);
            Floor4.SetActive(true);
        }
            

        if (RandomIndex == 0)
        {
            Clue4.SetActive(true);
            Floor4.SetActive(true);
        }
            

        //Debug.Log("wylosowano" + RandomIndex);

    }
}
