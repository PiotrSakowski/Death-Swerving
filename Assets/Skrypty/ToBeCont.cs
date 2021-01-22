using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToBeCont : MonoBehaviour
{
    public GameObject EndPanel;
    public GameObject Duch;
    private void Awake()
    {
     
    }
    private void Update()
    {
        if (EndPanel.activeInHierarchy == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("menu", LoadSceneMode.Single);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Duch)
        {
            
                EndPanel.SetActive(true);
            

            
        }
    }
        
    
}
