using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kursoroff : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            Screen.lockCursor = false;
        else
            Screen.lockCursor = true;
    }
}
