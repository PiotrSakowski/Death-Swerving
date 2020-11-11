using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nowy Dialog", menuName = "Dialog")]

public class Dialog : ScriptableObject
{
    [TextArea(15,20)]
    public string[] TekstDialogu;

    public Sprite[] ObrazekPostaci;

    public Sprite[] ObrazekDucha;

}
