using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogiDemona : MonoBehaviour
{
    public Dialog Dialog1Item;
    public Dialog Dialog2Item;
    public Dialog Dialog3Item;
    

    public GameObject Ubranie1UI, Ubranie2UI, Ubranie3UI;

    private bool off1;
    private bool off2;
    private bool off3;


    private void Start()
    {
        off1 = true;
        off2 = false;
        off3 = false;
    }

    private void Update()
    {
        if ((Ubranie1UI.activeInHierarchy) && (off1 == true))
        {
            gameObject.GetComponent<DialogNPC>().DialogPostaci = Dialog1Item;
            
            off1 = false;
            off2 = true;

            AktywatorUbraniaUI.pokazane1 = true;
        }
        if ((Ubranie2UI.activeInHierarchy) && (off2 == true))
        {
            gameObject.GetComponent<DialogNPC>().DialogPostaci = Dialog2Item;

            off2 = false;
            off3 = true;

            AktywatorUbraniaUI.pokazane2 = true;
        }
        if ((Ubranie3UI.activeInHierarchy) && (off3 == true))
        {
            gameObject.GetComponent<DialogNPC>().DialogPostaci = Dialog3Item;

            off3 = false;

            AktywatorUbraniaUI.pokazane3 = true;
        }
    }





}
