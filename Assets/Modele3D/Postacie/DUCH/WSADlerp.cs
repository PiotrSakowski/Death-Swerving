using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSADlerp : MonoBehaviour
{
    public Transform pion;
    public Transform w, s, a, d;
    public float speed = 0.01f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.rotation = Quaternion.Lerp(pion.rotation, w.rotation, Time.time * speed);
        else
            transform.rotation = Quaternion.Lerp(w.rotation, pion.rotation, Time.time * speed);

        if (Input.GetKey(KeyCode.S))
            transform.rotation = Quaternion.Lerp(pion.rotation, s.rotation, Time.time * speed);
        else
            transform.rotation = Quaternion.Lerp(s.rotation, pion.rotation, Time.time * speed);

        if (Input.GetKey(KeyCode.A))
            transform.rotation = Quaternion.Lerp(pion.rotation, a.rotation, Time.time * speed);
        else
            transform.rotation = Quaternion.Lerp(a.rotation, pion.rotation, Time.time * speed);

        if (Input.GetKeyDown(KeyCode.D))
            transform.rotation = Quaternion.Lerp(pion.rotation, d.rotation, Time.time * speed);
        else
            transform.rotation = Quaternion.Lerp(d.rotation, pion.rotation, Time.time * speed);

    }
}
