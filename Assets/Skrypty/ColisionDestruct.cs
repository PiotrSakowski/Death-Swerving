using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionDestruct : MonoBehaviour
{
    public GameObject zamkniecie,lustro;

    void OnTriggerEnter(Collider collision)
    {
        zamkniecie.SetActive(true);
        gameObject.SetActive(false);
        lustro.SetActive(false);

    }
    
    }
