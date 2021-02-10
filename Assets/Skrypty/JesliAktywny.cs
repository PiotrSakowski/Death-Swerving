using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JesliAktywny : MonoBehaviour
{
    public GameObject banan, PanelDialogowy;
    public GameObject DialogZablokowany,DialogDoZebrania;
    
    public WykonywaczDialogu WykonywaczPanelu;
    public Dialog Wyłączający;

    int cos = 1;
    
    private void Update()
    {
        if (banan == null && cos==1 && PanelDialogowy.activeInHierarchy == true)
        { 
            if(WykonywaczPanelu.dialogPodgladowy == Wyłączający) { 
            DialogZablokowany.SetActive(false);
            //DialogDoZebrania.SetActive(true); to w aktywatore ubrania
            cos += 1;
            }
        }
    }
}
