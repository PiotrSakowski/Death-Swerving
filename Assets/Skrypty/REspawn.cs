using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REspawn : MonoBehaviour
{
    Vector3 StartPoint;


    void Start()
    {
        StartPoint = transform.position;
    }
    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.CompareTag("respawnZone"))
        {
            // Debug.Log("zone");
            transform.position = StartPoint;
        }
    }
    //   void Update()
    // {
    //   if (gameObject.CompareTag("respawnZone"))
    // {
    //   Debug.Log("zone");
    // transform.position = StartPoint;
    //            Application.Quit();
    //      }
    //}




}
