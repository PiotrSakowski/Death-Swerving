using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogiZlego : MonoBehaviour
{
    public Dialog DialogSiekiera, Zly0Item, DialogMartwaWinda;
    public GameObject BoneMesh, SiekieraUI, PanelDialogowy, DzwigniaNieba,DzwigniaPiekla, ZlyZywy,ZlyDead;
    public GameObject Niebo1, Niebo2, Pieklo1, Pieklo2;


    private void Update()
    {
        if ((SiekieraUI.activeInHierarchy))
        {
            gameObject.GetComponent<DialogNPC>().DialogPostaci = DialogSiekiera;

            if ((PanelDialogowy.activeInHierarchy) && (WykonywaczDialogu.dialog == gameObject.GetComponent<DialogiZlego>().DialogSiekiera))
            {
                DzwigniaNieba.SetActive(false);
                DzwigniaPiekla.SetActive(true);
                ZlyZywy.SetActive(false);
                ZlyDead.SetActive(true);

                Niebo1.SetActive(false);
                Niebo2.SetActive(false);
                Pieklo1.SetActive(true);
                Pieklo2.SetActive(true);

                DialogNPC Winda = GameObject.Find("Winda dialog").GetComponent<DialogNPC>();
                Winda.DialogPostaci = DialogMartwaWinda;
            }

        }

        if ((PanelDialogowy.activeInHierarchy) && (WykonywaczDialogu.dialog == gameObject.GetComponent<DialogiZlego>().Zly0Item))
        {
            BoneMesh.GetComponent<BoxCollider>().enabled = true;
        }

    }
}

