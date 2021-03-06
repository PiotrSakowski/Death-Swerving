﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class raycast : MonoBehaviour {
    public GameObject Klucz;
    public GameObject KluczUI, PanelDialogowy;
    public Image Celownik;
    public Sprite Aim, Grab, Talk;

    public GameObject Zakonczenie;

    public LayerMask mask;

    void Update() {
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, 10f, mask)) {

            //Debug.Log(hit.collider.gameObject.name);
            if(hit.collider.gameObject.layer == LayerMask.NameToLayer("Default")) {
                Celownik.sprite = Aim;
                return;
            }

            Debug.DrawRay(ray.origin, ray.direction, Color.red, 5f, true);

            InteractionItem aa = hit.collider.GetComponent<InteractionItem>();


            if(aa == null)
                return;
            Celownik.sprite = aa.celownik;
            if (Input.GetMouseButton(0)) {
                aa.Interact();
            }

            if (hit.collider.gameObject.tag == "Przedmiot")
            {
                GameObject Przedmiot = hit.collider.gameObject;
                Animator K_Animator;
                K_Animator = Przedmiot.GetComponent<Animator>();
                K_Animator.SetTrigger("klucztrigger");
            }

            if (hit.collider.gameObject.tag == "Dzwignia")
            {
                if (Input.GetMouseButton(0))
                    Zakonczenie.SetActive(true);
            }


        }
            else {
            Celownik.sprite = Aim;
        }

    }

}