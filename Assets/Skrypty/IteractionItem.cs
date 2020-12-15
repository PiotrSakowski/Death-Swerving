using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionItem : MonoBehaviour {

    public Sprite celownik;
    protected Animator anim;

    protected virtual void Awake() {
        anim = gameObject.GetComponent<Animator>();
    }

    public virtual void Interact() {

    }
}
