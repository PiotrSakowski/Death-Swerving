using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WykonywaczDialogu : MonoBehaviour
{
    public static Dialog dialog;

    public GameObject PanelDialogowy;

    public Text TekstDialogu;
    public Image ObrazekPostaci;
    public Image ObrazekDucha;

    //public static Text TekstDialoguX;
    //public static Image ObrazekPostaciX;
    //public static Image ObrazekDuchaX;

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
        //TekstDialogu = TekstDialoguX;
        //ObrazekPostaci = ObrazekPostaciX;
       // ObrazekDucha = ObrazekDuchaX;

        if (PozycjaDialogu >= dialog.TekstDialogu.Length)
        {
            //Destroy(gameObject);
            //dialog = null;
            PanelDialogowy.SetActive(false);
            Debug.Log("Koniec dialogu");
            PozycjaDialogu = 0;

           // TekstDialogu.text = null;
            //ObrazekPostaci.sprite = null;
           // ObrazekDucha.sprite = null;

        }

        if (Input.GetKeyDown(KeyCode.E) )//&& (PanelDialogowy.active))
        {
            

            if (PozycjaDialogu < dialog.TekstDialogu.Length)
            {
                PozycjaDialogu = PozycjaDialogu + 1;
            }
            


        }

        TekstDialogu.text = dialog.TekstDialogu[PozycjaDialogu];
        ObrazekPostaci.sprite = dialog.ObrazekPostaci[PozycjaDialogu];
        ObrazekDucha.sprite = dialog.ObrazekDucha[PozycjaDialogu];

    }

}
