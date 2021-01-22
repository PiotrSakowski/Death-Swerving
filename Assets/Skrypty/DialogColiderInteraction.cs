using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogColiderInteraction : MonoBehaviour
{
    public GameObject ColiderUruchamiajacy;
    DialogNPC dialog;
    public GameObject PanelDialogowy;

    public AudioSource DzwiekPostaci;

    void Awake()
    {
        dialog = GetComponent<DialogNPC>();
        
        PanelDialogowy = GameObject.Find("Panel_Dialogowy1");
    }
    
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == ColiderUruchamiajacy)
        {
            WykonywaczDialogu.dialog = dialog.DialogPostaci;
            PanelDialogowy.SetActive(true);

            DzwiekPostaci.Play();
            gameObject.SetActive(false);
        }

    }

        }
