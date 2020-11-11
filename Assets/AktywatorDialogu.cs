using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktywatorDialogu : MonoBehaviour
{
    public GameObject PanelDialogowy;
    public bool UruchamiaColider;
    public GameObject ColiderUruchamiajacy;
    public bool UruchamiaZebranie;
    public bool UruchamiaInterakcja;

    public Dialog dialogColidera;


    void Start()
    {
        PanelDialogowy.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
           // PanelDialogowy.SetActive(true);

        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject == ColiderUruchamiajacy) && (UruchamiaColider == true))
        {

            //WykonywaczDialogu.PozycjaDialogu = 1;
            //WykonywaczDialogu.dialog = null;
            WykonywaczDialogu.dialog = dialogColidera;
            
            PanelDialogowy.SetActive(true);

            //WykonywaczDialogu.TekstDialoguX.text = dialogColidera.TekstDialogu[0];
            //WykonywaczDialogu.ObrazekPostaciX.sprite = dialogColidera.ObrazekPostaci[0];
            //WykonywaczDialogu.ObrazekDuchaX.sprite = dialogColidera.ObrazekDucha[0];


        }
    }
}
