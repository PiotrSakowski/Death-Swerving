using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WyborPoziomu : MonoBehaviour
{
    public void Poziom1()
    {

        PlayerPrefs.SetString("Startpoint", "LVL1");
        SceneManager.LoadScene("scenagry", LoadSceneMode.Single);
        
    }

    public void Poziom2()
    {

        PlayerPrefs.SetString("Startpoint", "LVL2");
        SceneManager.LoadScene("scenagry", LoadSceneMode.Single);

    }

    public void Poziom3()
    {

        PlayerPrefs.SetString("Startpoint", "LVL3");
        SceneManager.LoadScene("scenagry", LoadSceneMode.Single);

    }

    public void Poziom4()
    {

        PlayerPrefs.SetString("Startpoint", "LVL4");
        SceneManager.LoadScene("scenagry", LoadSceneMode.Single);

    }

    public void Poziom5()
    {

        PlayerPrefs.SetString("Startpoint", "LVL5");
        SceneManager.LoadScene("scenagry", LoadSceneMode.Single);

    }

    public void Poziom6()
    {

        PlayerPrefs.SetString("Startpoint", "LVL6");
        SceneManager.LoadScene("scenagry", LoadSceneMode.Single);

    }

}
