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

    public enum GhostEmotions { angry, happy, sad, cuffed }
    public GhostEmotions state;
    public Sprite Npc;
}
