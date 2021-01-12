using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogiCerbera : MonoBehaviour
{
    public Dialog DialogCerbBone, Cerb0Item;
    public GameObject BoneMesh, BoneUI, PanelDialogowy, DrzwiCerbera;

    private void Update()
    {
        if ((BoneUI.activeInHierarchy))
        {
            gameObject.GetComponent<DialogNPC>().DialogPostaci = DialogCerbBone;

            if ((PanelDialogowy.activeInHierarchy) && (WykonywaczDialogu.dialog == gameObject.GetComponent<DialogiCerbera>().DialogCerbBone))
            {
                Animator D_Animator = DrzwiCerbera.GetComponent<Animator>();
                D_Animator.SetTrigger("Odklucznik");
            }
            
        }

        if ((PanelDialogowy.activeInHierarchy) && (WykonywaczDialogu.dialog == gameObject.GetComponent<DialogiCerbera>().Cerb0Item))
        {
            BoneMesh.GetComponent<BoxCollider>().enabled = true;
        }

    }
}
