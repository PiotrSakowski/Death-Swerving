using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogInteractionItem : InteractionItem
{
    DialogNPC dialog;
    public GameObject PanelDialogowy;

    protected override void Awake()
    {
        base.Awake();
        dialog = GetComponent<DialogNPC>();
        PanelDialogowy = GameObject.Find("Panel_Dialogowy1");
        //anim.SetTrigger("klucztrigger");
    }

    public override void Interact()
    {

        //WykonywaczDialogu.dialog = dialog.DialogPostaci;
        //WykonywaczDialogu.Instance.PanelDialogowy.SetActive(true);

        if (Input.GetMouseButtonDown(0) && dialog != null)
        {
                        WykonywaczDialogu.dialog = dialog.DialogPostaci;
                        PanelDialogowy.SetActive(true);
                    }

        }
    }

