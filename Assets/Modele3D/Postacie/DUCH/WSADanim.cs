using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSADanim : MonoBehaviour
{
    Animator m_Animator;
    
    void Start()
    {

        m_Animator = gameObject.GetComponent<Animator>();

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            m_Animator.SetBool("Wpress", true);
        else
            m_Animator.SetBool("Wpress", false);

        if (Input.GetKeyDown(KeyCode.S))
            m_Animator.SetBool("Spress", true);
        else
            m_Animator.SetBool("Spress", false);

        if (Input.GetKeyDown(KeyCode.A))
            m_Animator.SetBool("Apress", true);
        else
            m_Animator.SetBool("Apress", false);

        if (Input.GetKeyDown(KeyCode.D))
            m_Animator.SetBool("Dpress", true);
        else
            m_Animator.SetBool("Dpress", false);

    }
}
