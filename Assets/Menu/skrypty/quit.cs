using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Wychodzenie();
        }
    }

    public void Wychodzenie()
    {
            Application.Quit();
    }
}