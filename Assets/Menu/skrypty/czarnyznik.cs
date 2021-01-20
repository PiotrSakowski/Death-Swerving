using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class czarnyznik : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Czarnyznik");
    }

    IEnumerator Czarnyznik()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }

}
