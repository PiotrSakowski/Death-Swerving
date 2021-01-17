using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtwieraczDrzwi : InteractionItem
{
    public Animator D_Animator;
    public GameObject KluczDoDrzwi;
    public GameObject PanelDialogowy;
    public Dialog dialogDrzwiOtwartych;
    public Dialog dialogDrzwiZamknietych;

    private bool wylacznik;

    public AudioSource DzwiekPostaci;

    private void Start()
    {
        wylacznik = true;
    }


    void Update()
    {
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 10f))
        {

            Debug.DrawRay(ray.origin, ray.direction, Color.yellow, 5f, true);
            if (hit.collider.gameObject.tag == "Drzwi")
            {
                GameObject Drzwi = hit.collider.gameObject;
                //Animator D_Animator;
                //D_Animator = Drzwi.GetComponent<Animator>();

                if (Input.GetMouseButton(0) && (wylacznik == true))
                    {

                        WykonywaczDialogu.dialog = dialogDrzwiZamknietych;

                        PanelDialogowy.SetActive(true);

                    }

                if (Input.GetMouseButton(0) && (wylacznik == false))
                {

                    WykonywaczDialogu.dialog = dialogDrzwiOtwartych;

                    PanelDialogowy.SetActive(true);

                }

                if (Input.GetMouseButton(0) && (KluczDoDrzwi.activeInHierarchy == true) && (wylacznik == true))
                {

                    D_Animator.SetTrigger("Odklucznik");

                    DzwiekPostaci.Play();

                    WykonywaczDialogu.dialog = dialogDrzwiOtwartych;

                    PanelDialogowy.SetActive(true);

                    wylacznik = false;
                }
                
                    


                
                
            }
        }
    }
}
