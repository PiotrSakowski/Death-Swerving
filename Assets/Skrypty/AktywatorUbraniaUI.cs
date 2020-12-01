using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktywatorUbraniaUI : MonoBehaviour
{
    public GameObject Ubranie1, Ubranie2, Ubranie3;
    public GameObject Ubranie1UI, Ubranie2UI, Ubranie3UI;
    public GameObject PanelDialogowy, DrzwiDemona;

    private bool off1;
    private bool off2;
    private bool off3;

    public static bool pokazane1;
    public static bool pokazane2;
    public static bool pokazane3;

    private void Start()
    {
        off1 = true;
        off2 = true;
        off3 = true;

        pokazane1 = false;
        pokazane2 = false;
        pokazane3 = false;


    }

    private void Update()
    {
        

        if((Ubranie1 == null) && (off1 == true))
        {
            Ubranie1UI.SetActive(true);
            off1 = false;
        }

        if ((Ubranie2 != null) && (pokazane1 == true) && (PanelDialogowy.activeInHierarchy) && (WykonywaczDialogu.dialog == gameObject.GetComponent<DialogiDemona>().Dialog1Item))
        {
            Ubranie2.GetComponent<BoxCollider>().enabled = true;
        }

        if ((Ubranie2 == null) && (off2 == true))
        {
            Ubranie2UI.SetActive(true);
            off2 = false;
        }

        if ((Ubranie3 != null) && (pokazane2 == true) && (PanelDialogowy.activeInHierarchy) && (WykonywaczDialogu.dialog == gameObject.GetComponent<DialogiDemona>().Dialog2Item))
        {
            Ubranie3.GetComponent<BoxCollider>().enabled = true;
        }

        if ((Ubranie3 == null) && (off3 == true))
        {
            Ubranie3UI.SetActive(true);
            off3 = false;
        }

        if ((PanelDialogowy.activeInHierarchy) && (WykonywaczDialogu.dialog == gameObject.GetComponent<DialogiDemona>().Dialog3Item))
        {
            Animator D_Animator = DrzwiDemona.GetComponent<Animator>();
            D_Animator.SetTrigger("Odklucznik");
        }

    }
}
