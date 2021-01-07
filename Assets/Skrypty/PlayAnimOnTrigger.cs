using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimOnTrigger : MonoBehaviour
{

    public Animator anim;
    public AudioClip sound;

    void Start()
    {
        anim.enabled = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == ("Player"))
        {
            anim.enabled = true;
            AudioSource.PlayClipAtPoint(sound, transform.position);
        }
    }
}
