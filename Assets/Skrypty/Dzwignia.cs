using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dzwignia : InteractionItem
{
    public GameObject EndPanel;

    private void Update()
    {

        if (EndPanel.activeInHierarchy == true && Input.GetKeyDown(KeyCode.E))
            SceneManager.LoadScene("menu", LoadSceneMode.Single);

    }
}
