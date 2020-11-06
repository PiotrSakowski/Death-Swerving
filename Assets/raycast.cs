using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    public GameObject Klucz;
    public GameObject KluczUI;

    void Update()
    {
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 50f))
        {
            Debug.DrawRay(ray.origin, ray.direction, Color.red, 5f, true);
            if (hit.collider.gameObject == Klucz)
            {
                //Debug.Log("Klucz_znaleziony");
                Animator K_Animator;
                K_Animator = Klucz.GetComponent<Animator>();
                K_Animator.SetTrigger("klucztrigger");

                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Klucz_zebrany");
                    Destroy(hit.collider.gameObject);
                    KluczUI.SetActive(true);
                }
            }
           // else
           // {
           //     Animator K_Animator;
           //     K_Animator = Klucz.GetComponent<Animator>();
           //     K_Animator.SetBool("kluczanim", false);
           // }

        }
    }
    
}