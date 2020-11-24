using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasekPostepu : MonoBehaviour
{
    public float LiczbaPrzedmiotow;
    public GameObject[] przedmioty;

    void Update()
    {
        przedmioty = GameObject.FindGameObjectsWithTag("IkonaPrzedmiotu");

        this.gameObject.transform.localScale = new Vector3(przedmioty.Length / LiczbaPrzedmiotow, 1, 1);
    }
}
