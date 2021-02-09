using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktywatorUbran : MonoBehaviour
{
    public GameObject Plaszcz, Szal, Cylinder, PlaszczUI, SzalUI, CylinderUI, PanelDialogowy;

    int cos = 1;

    void Update()
    {
        if (PlaszczUI.activeInHierarchy == true && SzalUI.activeInHierarchy == false)
            Plaszcz.SetActive(true);

        if (SzalUI.activeInHierarchy == true && CylinderUI.activeInHierarchy == false)
        {
            Plaszcz.SetActive(false);
            Szal.SetActive(true);
        }

        if (Szal.activeInHierarchy == true && CylinderUI.activeInHierarchy == true && cos==1)
        {
            Szal.SetActive(false);
            Cylinder.SetActive(true);
            cos += 1;
        }

        if (Cylinder.activeInHierarchy == true && PanelDialogowy.activeInHierarchy == true)
        {
            Cylinder.SetActive(false);

        }
    }
}
