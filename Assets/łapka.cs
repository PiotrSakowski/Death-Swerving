using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class łapka : MonoBehaviour
{
    public Image Celownik;
    public Sprite Aim, Grab;


    void Update()
    {
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            Debug.DrawRay(ray.origin, ray.direction, Color.red, 5f, true);
            if (hit.collider.gameObject.tag == "Przedmiot")
            {
                //Celownik.sprite = Grab;

            }
            else
            {
                Celownik.sprite = Aim;
            }

        }
    }

}
