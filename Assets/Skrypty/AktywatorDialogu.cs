using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktywatorDialogu : MonoBehaviour
{
    public GameObject PanelDialogowy;
    public GameObject ColiderUruchamiajacy;
    public Dialog dialogColideraa;


    void OnTriggerEnter(Collider collision)
    {
        if ((collision.gameObject == ColiderUruchamiajacy))
        {
            WykonywaczDialogu.dialog = dialogColideraa;

            PanelDialogowy.SetActive(true);

        }
    }



}
