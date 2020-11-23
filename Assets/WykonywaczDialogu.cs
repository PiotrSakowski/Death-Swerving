using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WykonywaczDialogu : MonoBehaviour
{
    public static Dialog dialog;

    public GameObject PanelDialogowy, PanelP, PanelL, Celownik;

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


    void Start()
    {
        PozycjaDialogu = 0;

        Move = Player.GetComponent<Poruszanie>();
        LookP = Player.GetComponent<MouseLook>();

        dialog = dialogPodgladowy;

    }


    private void Update()
    {
        dialogPodgladowy = dialog;

        if (PozycjaDialogu >= dialog.panels.Length)
        {
            PanelDialogowy.SetActive(false);
            Debug.Log("Koniec dialogu");
            PozycjaDialogu = 0;
            PanelP.SetActive(true); 
            PanelL.SetActive(true);
            Celownik.SetActive(true);
            Move.enabled = true;
            LookP.enabled = true;
            LookC.enabled = true;

        }

        if (Input.GetKeyDown(KeyCode.E) )
        {
            if (PozycjaDialogu < dialog.panels.Length)
            {
                PozycjaDialogu ++;
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
            LookP.enabled = false;
            LookC.enabled = false;
        }

        if(ObrazekPostaci.sprite == null)
        {
            ObrazekPostaci.sprite = PustyObrazek;
        }

    }

}
