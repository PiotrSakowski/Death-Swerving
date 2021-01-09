using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Respawn", menuName = "Spawnmenu")]

public class REspawn : ScriptableObject
{
    [SerializeField]
    public AktywnyCheckpoint checkpoint;
}

[System.Serializable]
public struct AktywnyCheckpoint
{
    public enum Checkpoint { Start, Poz1Klucz, Poz2Demon, Poz3Robak, Poz4Labirynt, Poz5Cerber, Poz6Powieszchnia, Poz0DevRoom }
    public Checkpoint Pozycja;
}