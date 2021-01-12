using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KluczInteraction : InteractionItem
{
    DialogNPC dialog;
    public GameObject Klucz;
    public GameObject KluczUI;

    public AudioSource DzwiekPostaci;

    protected override void Awake()
    {
        base.Awake();
        dialog = GetComponent<DialogNPC>();
    }

    public override void Interact()
    {
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
                DzwiekPostaci.Play();
            }


        }

    }
}

