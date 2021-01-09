using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poruszanie : MonoBehaviour
{
    public float thrustW = 1.0f;
    public Rigidbody rb;
    public float maxZmianaPredkosci = 10.0f;
    static Transform StartPoint;
    public REspawn RespawnSystem;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartPoint = Checkpoints.Instance.GetTransform(RespawnSystem.checkpoint.Pozycja);
        transform.position = StartPoint.position;
    }

    void FixedUpdate()
    {

        Vector3 maxPredkosc = new Vector3(Input.GetAxis(("Horizontal")), 0, Input.GetAxis("Vertical"));
        maxPredkosc = transform.TransformDirection(maxPredkosc);
        maxPredkosc *= thrustW;

        Vector3 predkosc = rb.velocity;
        Vector3 zmianaPredkosci = (maxPredkosc - predkosc);
        zmianaPredkosci.x = Mathf.Clamp(zmianaPredkosci.x, -maxZmianaPredkosci, maxZmianaPredkosci);
        zmianaPredkosci.z = Mathf.Clamp(zmianaPredkosci.z, -maxZmianaPredkosci, maxZmianaPredkosci);
        zmianaPredkosci.y = 0;
        rb.AddForce(zmianaPredkosci, ForceMode.VelocityChange);

    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.CompareTag("respawnZone"))
        {
            transform.position = StartPoint.position;
        }
    }
}

    





