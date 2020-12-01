using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZebranieRobiDialog : MonoBehaviour
{
    public GameObject PanelDialogowy;

    public GameObject ZbieranyPrzedmiot;

    public Dialog dialogColidera;

    private bool wylacznik;

    private void Start()
    {
        wylacznik = true;
    }


    void Update()
    {
        if (ZbieranyPrzedmiot.activeInHierarchy && (wylacznik == true))
        {
            WykonywaczDialogu.dialog = dialogColidera;

            PanelDialogowy.SetActive(true);

            wylacznik = false;
        }
    }
}
