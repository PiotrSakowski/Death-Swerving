using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Animator UiAnim;
    public Sprite Aim, AimGrab;
    public Image Cel;

    //demo/////////////////////////////
    public bool grab;
    /////////////////////////////
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (UiAnim.GetBool("Hidden") == true)
            {
                UiAnim.SetBool("Hidden", false);
            } else
            {
                UiAnim.SetBool("Hidden", true);
            }
        }

        //demo/////////////////////////////
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (grab == true)
            {
                grab = false;
                Cel.sprite = Aim;
            } else
            {
                grab = true;
                Cel.sprite = AimGrab;
            }
        }
        /////////////////////////////
    }
}
