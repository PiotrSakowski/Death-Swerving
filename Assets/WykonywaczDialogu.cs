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

    public int PozycjaDialogu;

    public Dialog dialogPodgladowy;


    void Start()
    {
        TekstDialogu.text = null;
        ObrazekPostaci.sprite = null;
        ObrazekDucha.sprite = null;
        PozycjaDialogu = 0;
        //TekstDialogu.text = dialog.TekstDialogu[PozycjaDialogu];
        //ObrazekPostaci.sprite = dialog.ObrazekPostaci[PozycjaDialogu];
        //ObrazekDucha.sprite = dialog.ObrazekDucha[PozycjaDialogu];

        Move = Player.GetComponent<Poruszanie>();
        LookP = Player.GetComponent<MouseLook>();

    }


    private void Update()
    {
        //dialogPodgladowy = dialog;

        ObrazekDucha.sprite = GhostSpriteLoader.Instance.GetSprit(DialogPanel.GhostEmotions.angry);

        //if (PozycjaDialogu >= dialog.TekstDialogu.Length)
        //{
        //    PanelDialogowy.SetActive(false);
        //    Debug.Log("Koniec dialogu");
        //    PozycjaDialogu = 0;
        //    PanelP.SetActive(true); 
        //    PanelL.SetActive(true);
        //    Celownik.SetActive(true);
        //    Move.enabled = true;
        //    LookP.enabled = true;
        //    LookC.enabled = true;

        //}

        //if (Input.GetKeyDown(KeyCode.E) )
        //{
        //    if (PozycjaDialogu < dialog.TekstDialogu.Length)
        //    {
        //        PozycjaDialogu ++;
        //    }
        //}

        //if (PanelDialogowy.activeInHierarchy)
        //{
        //    PanelP.SetActive(false);
        //    PanelL.SetActive(false);
        //    Celownik.SetActive(false);
        //    Move.enabled = false;
        //    LookP.enabled = false;
        //    LookC.enabled = false;
        //}

        //TekstDialogu.text = dialog.TekstDialogu[PozycjaDialogu];
        //ObrazekPostaci.sprite = dialog.ObrazekPostaci[PozycjaDialogu];
        //ObrazekDucha.sprite = dialog.ObrazekDucha[PozycjaDialogu];

    }

}
