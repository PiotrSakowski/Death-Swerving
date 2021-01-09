using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpriteLoader : MonoBehaviour {
    public static GhostSpriteLoader Instance { get; private set; }

    public Sprite[] sprites;

    private void Awake() {
        Instance = this;

    }

    public Sprite GetSprite(DialogPanel.GhostEmotions e) {
        return sprites[(int)e];
    }
}
