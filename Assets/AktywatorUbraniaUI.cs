using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktywatorUbraniaUI : MonoBehaviour
{
    public GameObject Ubranie1, Ubranie2, Ubranie3;
    public GameObject Ubranie1UI, Ubranie2UI, Ubranie3UI;

    private bool off1;
    private bool off2;
    private bool off3;

    bool pokazane1;
    bool pokazane2;
    bool pokazane3;

    private void Start()
    {
        off1 = true;
        off2 = true;
        off3 = true;

        //pokazane1 = false;
        //pokazane2 = false;
        //pokazane3 = false;


    }

    private void Update()
    {
        

        if((Ubranie1 == null) && (off1 == true))
        {
            Ubranie1UI.SetActive(true);
            Ubranie2.GetComponent<BoxCollider>().enabled = true;
            off1 = false;
        }
        if ((Ubranie2 == null) && (off2 == true))
        {
            Ubranie2UI.SetActive(true);
            Ubranie3.GetComponent<BoxCollider>().enabled = true;
            off2 = false;
        }
        if ((Ubranie3 == null) && (off3 == true))
        {
            Ubranie3UI.SetActive(true);
            off3 = false;
            return;
        }

    }
}
