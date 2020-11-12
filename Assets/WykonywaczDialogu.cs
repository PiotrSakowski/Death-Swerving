using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WykonywaczDialogu : MonoBehaviour
{
    public static Dialog dialog;

    public GameObject PanelDialogowy, PanelP, PanelL, Celownik;

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
        TekstDialogu.text = dialog.TekstDialogu[PozycjaDialogu];
        ObrazekPostaci.sprite = dialog.ObrazekPostaci[PozycjaDialogu];
        ObrazekDucha.sprite = dialog.ObrazekDucha[PozycjaDialogu];
        

    }


    private void Update()
    {
        dialogPodgladowy = dialog;
      
        if (PozycjaDialogu >= dialog.TekstDialogu.Length)
        {
            PanelDialogowy.SetActive(false);
            Debug.Log("Koniec dialogu");
            PozycjaDialogu = 0;
            PanelP.SetActive(true); 
            PanelL.SetActive(true);
            Celownik.SetActive(true);

        }

        if (Input.GetKeyDown(KeyCode.E) )
        {
            if (PozycjaDialogu < dialog.TekstDialogu.Length)
            {
                PozycjaDialogu = PozycjaDialogu + 1;
            }
        }

        if (PanelDialogowy.activeInHierarchy)
        {
            PanelP.SetActive(false);
            PanelL.SetActive(false);
            Celownik.SetActive(false);
        }

        TekstDialogu.text = dialog.TekstDialogu[PozycjaDialogu];
        ObrazekPostaci.sprite = dialog.ObrazekPostaci[PozycjaDialogu];
        ObrazekDucha.sprite = dialog.ObrazekDucha[PozycjaDialogu];

    }

}
