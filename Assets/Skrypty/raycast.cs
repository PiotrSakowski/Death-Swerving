using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class raycast : MonoBehaviour
{
    public GameObject Klucz;
    public GameObject  KluczUI, PanelDialogowy;
    public Image Celownik;
    public Sprite Aim, Grab, Talk;

    public LayerMask mask;

    void Update()
    {
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 10f, mask))
        {
            Debug.DrawRay(ray.origin, ray.direction, Color.red, 5f, true);

            
            
            if (hit.collider.gameObject == Klucz)
            {
                //Debug.Log("Klucz_znaleziony");
                Animator K_Animator;
                K_Animator = Klucz.GetComponent<Animator>();
                K_Animator.SetTrigger("klucztrigger");
                Celownik.sprite = Grab;

                if (Input.GetMouseButton(0))
                {
                    //Debug.Log("Klucz_zebrany");
                    Destroy(hit.collider.gameObject);
                    KluczUI.SetActive(true);
                }
            }
            else
            {
                    if (hit.collider.gameObject.tag == "NPC")
                    {
                        GameObject Npc = hit.collider.gameObject;
                        DialogNPC dialog = Npc.GetComponent<DialogNPC>();
                        Celownik.sprite = Talk;

                        if (Input.GetMouseButtonDown(0))
                        {
                            WykonywaczDialogu.dialog = dialog.DialogPostaci;
                            PanelDialogowy.SetActive(true);
                        }

                    }
                    else
                    {
                    if (hit.collider.gameObject.tag == "Drzwi")
                    {
                        GameObject Drzwi = hit.collider.gameObject;
                        DialogNPC dialog = Drzwi.GetComponent<DialogNPC>();
                        Celownik.sprite = Grab;

                        if (Input.GetMouseButtonDown(0))
                        {
                           // WykonywaczDialogu.dialog = dialog.DialogPostaci;
                            PanelDialogowy.SetActive(true);
                        }
                    }
                    else {
                        if (hit.collider.gameObject.tag == "Przedmiot")
                        {
                            GameObject Przedmiot = hit.collider.gameObject;
                            Animator K_Animator;
                            K_Animator = Przedmiot.GetComponent<Animator>();
                            K_Animator.SetTrigger("klucztrigger");
                            Celownik.sprite = Grab;
                            if (Input.GetMouseButton(0))
                            {
                                Destroy(hit.collider.gameObject);
                                //KluczUI.SetActive(true);
                            }
                        }
                        else
                        {
                            Celownik.sprite = Aim;
                        }
                        
                    }
                    
                    //Celownik.sprite = Aim;
                    //     Animator K_Animator;
                    //     K_Animator = Klucz.GetComponent<Animator>();
                    //     K_Animator.SetBool("kluczanim", false);
                
            }
         }


        }
        else
        {
            Celownik.sprite = Aim;
        }

    }
    
}