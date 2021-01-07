using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogStartOff : MonoBehaviour
{
    public GameObject PanelDialogowy;

    void Start()
    {

        PanelDialogowy.SetActive(false);
    }
}
