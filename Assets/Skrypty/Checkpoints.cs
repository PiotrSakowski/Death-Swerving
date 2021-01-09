using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public static Checkpoints Instance { get; private set; }

    public Transform[] Checkpointy;

    private void Awake()
    {
        Instance = this;

    }

    public Transform GetTransform(AktywnyCheckpoint.Checkpoint e)
    {
        return Checkpointy[(int)e];
    }
}
