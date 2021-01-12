using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtwieraczCerbera : MonoBehaviour
{
    public Animator D_Animator;
    public GameObject BoneUI;
    public GameObject PanelDialogowy;
    public Dialog dialogDrzwiOtwartych;
    public Dialog dialogDrzwiZamknietych;

    private bool wylacznik;

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

            Debug.DrawRay(ray.origin, ray.direction, Color.blue, 5f, true);
            if (hit.collider.gameObject.tag == "Drzwi")
            {
                GameObject Drzwi = hit.collider.gameObject;

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
                {
                    if (Input.GetMouseButton(0) && (BoneUI.activeInHierarchy == true) && (wylacznik == true) && (PanelDialogowy.activeInHierarchy) && (WykonywaczDialogu.dialog == gameObject.GetComponent<DialogiCerbera>().Cerb0Item))
                    {

                        //D_Animator.SetTrigger("Odklucznik");

                        WykonywaczDialogu.dialog = dialogDrzwiOtwartych;

                        PanelDialogowy.SetActive(true);

                        wylacznik = false;
                    }






                }
            }
        }
    }
}