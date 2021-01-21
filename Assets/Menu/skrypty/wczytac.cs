using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class wczytac : MonoBehaviour
{
    public GameObject ramka;

    public void graj()
    {
        ramka.SetActive(true);
    }

    public void xownik()
    {
        ramka.SetActive(false);
    }

    public void Nowa()
    {

        PlayerPrefs.SetString("Startpoint", "Start");
        SceneManager.LoadScene("scenagry", LoadSceneMode.Single);

    }

    public void Wczytywanie()
    {

        SceneManager.LoadScene("Wczytywanie", LoadSceneMode.Single);

    }

    public void Autorzy()
    {

        SceneManager.LoadScene("autorzy", LoadSceneMode.Single);

    }


}




