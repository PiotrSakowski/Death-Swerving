using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class powrot : MonoBehaviour
{
    public void wracajse()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
