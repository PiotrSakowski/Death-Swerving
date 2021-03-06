﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WykonywaczDialogu : MonoBehaviour
{
    public static Dialog dialog;

    public GameObject PanelDialogowy, PanelP, PanelL, Celownik, WSADinfo;

    public GameObject Player;
    private Poruszanie Move;
    private MouseLook LookP;
    public MouseLook LookC;

    public Text TekstDialogu;
    public Image ObrazekPostaci;
    public Image ObrazekDucha;
    public Sprite PustyObrazek;

    public int PozycjaDialogu;

    public Dialog dialogPodgladowy;

    Rigidbody RigidPlayera;


    void Start()
    {
        PozycjaDialogu = 0;

        Move = Player.GetComponent<Poruszanie>();
        LookP = Player.GetComponent<MouseLook>();

        dialog = dialogPodgladowy;

        RigidPlayera = Player.GetComponent(typeof(Rigidbody)) as Rigidbody;

    }


    private void Update()
    {
        dialogPodgladowy = dialog;


        if (Input.GetKeyDown(KeyCode.E) )
        {
            if (PozycjaDialogu < dialog.panels.Length-1)
            {
                PozycjaDialogu ++;
            }else
            {
                PozycjaDialogu = 0;
                PanelDialogowy.SetActive(false);
                //Debug.Log("Koniec dialogu");

                PanelP.SetActive(true);
                PanelL.SetActive(true);
                Celownik.SetActive(true);
                Move.enabled = true;
                RigidPlayera.drag = 1;
                LookP.enabled = true;
                LookC.enabled = true;

                if (WSADinfo != null)
                {
                    WSADinfo.SetActive(true);
                }
            }
        }

        TekstDialogu.text = dialog.panels[PozycjaDialogu].text;
        ObrazekPostaci.sprite = dialog.panels[PozycjaDialogu].Npc;
        ObrazekDucha.sprite = GhostSpriteLoader.Instance.GetSprite(dialog.panels[PozycjaDialogu].state);

        if (PanelDialogowy.activeInHierarchy)
        {
            PanelP.SetActive(false);
            PanelL.SetActive(false);
            Celownik.SetActive(false);
            Move.enabled = false;
            //RigidPlayera.velocity = new Vector3(0, 0, 0);
            RigidPlayera.drag = 10;
            LookP.enabled = false;
            LookC.enabled = false;

            if (WSADinfo != null)
            {
                WSADinfo.SetActive(false);
            }
        }

        if(ObrazekPostaci.sprite == null)
        {
            ObrazekPostaci.sprite = PustyObrazek;
        }

    }

}
