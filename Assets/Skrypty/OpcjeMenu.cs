using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OpcjeMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public bool lockCursor = true;
    public GameObject opcje;

    public GameObject Player;
    private Poruszanie Move;
    private MouseLook LookP;
    public MouseLook LookC;

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }


    public void SetVolume (float volume)
    {
        Debug.Log(volume);
        audioMixer.SetFloat("volume", volume);
    }

    private void Start()
    {
        Move = Player.GetComponent<Poruszanie>();
        LookP = Player.GetComponent<MouseLook>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Opcjeonoff()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            opcje.SetActive(true);

            Move.enabled = false;
            LookP.enabled = false;
            LookC.enabled = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
        else
        {
            Time.timeScale = 1;
            opcje.SetActive(false);

            Move.enabled = true;
            LookP.enabled = true;
            LookC.enabled = true;

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;


        }
    }

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Opcjeonoff();
           
               
        }
        
    }

}
