using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogInteractionItem : InteractionItem {
    DialogNPC dialog;

    protected override void Awake() {
        base.Awake();
        dialog = GetComponent<DialogNPC>();
    }

    public override void Interact() {

        //WykonywaczDialogu.dialog = dialog.DialogPostaci;
        WykonywaczDialogu.Instance.PanelDialogowy.SetActive(true);

    }
}

