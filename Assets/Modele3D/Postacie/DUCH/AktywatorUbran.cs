using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktywatorUbran : MonoBehaviour
{
    public GameObject Plaszcz, Szal, Cylinder, PlaszczUI, SzalUI, CylinderUI, PanelDialogowy,Demon;

    int cos = 1;

    void Update()
    {
        if (PlaszczUI.activeInHierarchy == true && SzalUI.activeInHierarchy == false)
            Plaszcz.SetActive(true);

        if (SzalUI.activeInHierarchy == true && CylinderUI.activeInHierarchy == false)
        {
            
            Szal.SetActive(true);
            Plaszcz.SetActive(false);
        }

        if (Szal.activeInHierarchy == true && CylinderUI.activeInHierarchy == true && cos==1)
        {
            
            Cylinder.SetActive(true);
            cos += 1;
            Szal.SetActive(false);
        }

        if (Cylinder.activeInHierarchy == true && PanelDialogowy.activeInHierarchy == true && (WykonywaczDialogu.dialog == Demon.GetComponent<DialogiDemona>().Dialog3Item) && cos==2)
        {
            Cylinder.SetActive(false);
            cos += 1;

        }
    }
}
