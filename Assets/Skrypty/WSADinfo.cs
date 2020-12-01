using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSADinfo : MonoBehaviour
{
    public GameObject Wjasny, Sjasny, Ajasny, Djasny;

    private void Start()
    {
        Wjasny.SetActive(false);
        Sjasny.SetActive(false);
        Ajasny.SetActive(false);
        Djasny.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {Wjasny.SetActive(true);}
        if (Input.GetKey(KeyCode.S))
        {Sjasny.SetActive(true);}
        if (Input.GetKey(KeyCode.A))
        {Ajasny.SetActive(true);}
        if (Input.GetKey(KeyCode.D))
        {Djasny.SetActive(true);}

        if((Wjasny.activeInHierarchy) && (Sjasny.activeInHierarchy) && (Ajasny.activeInHierarchy) && (Djasny.activeInHierarchy))
        {
            GameObject wsadownik = this.gameObject;
            Animator wsadznikacz;
            wsadznikacz = wsadownik.GetComponent<Animator>();
            wsadznikacz.SetTrigger("PrzeklikaneWSAD");
        }
    }
}
