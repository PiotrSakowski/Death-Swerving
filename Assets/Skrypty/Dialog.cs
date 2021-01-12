using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nowy Dialog", menuName = "Dialog")]

public class Dialog : ScriptableObject {
    [SerializeField]
    public DialogPanel[] panels;
}

[System.Serializable]
public struct DialogPanel {

    [TextArea(15, 20)]
    public string text;

    public enum GhostEmotions { angry,irritated, hungry ,love,natural,sad,suprised, cuffed, uncuffed, thinking , empty11}
    public GhostEmotions state;
    public Sprite Npc;
}
