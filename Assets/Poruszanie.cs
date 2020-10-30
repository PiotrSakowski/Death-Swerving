using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poruszanie : MonoBehaviour
{
    public float thrustW = 1.0f;
    public Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * thrustW);

        }



        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * (-thrustW));

        }



        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * (-thrustW));

        }
   


        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * thrustW);

        }
    }
}
