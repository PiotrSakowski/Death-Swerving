using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plytka : MonoBehaviour
{
    public GameObject zamkniecie;

    void OnTriggerEnter(Collider collision)
    {
        zamkniecie.SetActive(false);

    }
}
