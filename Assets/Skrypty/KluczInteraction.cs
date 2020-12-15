using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KluczInteraction : InteractionItem
{
    DialogNPC dialog;
    public GameObject Klucz;
    public GameObject KluczUI;

    protected override void Awake()
    {
        base.Awake();
        dialog = GetComponent<DialogNPC>();
        //anim.SetTrigger("klucztrigger");
    }

    public override void Interact()
    {

        //WykonywaczDialogu.dialog = dialog.DialogPostaci;
        //WykonywaczDialogu.Instance.PanelDialogowy.SetActive(true);

        //anim.SetTrigger("klucztrigger");

        if (Klucz == null)
        {
            return;
        }
        else
        {


            if (Input.GetMouseButton(0) && KluczUI != null)
            {
                Destroy(Klucz);
                KluczUI.SetActive(true);
            }


        }

    }
}

