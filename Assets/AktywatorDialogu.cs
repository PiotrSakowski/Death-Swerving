using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktywatorDialogu : MonoBehaviour
{
    public GameObject PanelDialogowy;

    public bool UruchamiaColider;
    public GameObject ColiderUruchamiajacy;

    public Dialog dialogColidera;


    void Start()
    {

        PanelDialogowy.SetActive(false);
    }



    void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject == ColiderUruchamiajacy) && (UruchamiaColider == true))
        {
            WykonywaczDialogu.dialog = dialogColidera;
            
            PanelDialogowy.SetActive(true);

        }
    }
}
