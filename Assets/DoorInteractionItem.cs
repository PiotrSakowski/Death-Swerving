using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractionItem : DialogInteractionItem {

    public GameObject KluczDoDrzwi;

    public override void Interact() {
        base.Interact();
        if((KluczDoDrzwi.activeInHierarchy == true))
            anim.SetTrigger("Odklucznik");
    }
}
