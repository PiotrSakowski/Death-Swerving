using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class OpcjeMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public bool lockCursor = true;
    public GameObject opcje;

    public GameObject Player;
    private Poruszanie Move;
    private MouseLook LookP;
    public MouseLook LookC;
    public TMPro.TMP_Dropdown qDrop;
    public Slider Volume, Sensivity;
   

    private void Start()
    {
        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("QualityLevel"));
        qDrop.value = PlayerPrefs.GetInt("QualityLevel");
        audioMixer.SetFloat("volume", PlayerPrefs.GetFloat("vol"));
        Volume.value = PlayerPrefs.GetFloat("vol");
        Sensivity.value = PlayerPrefs.GetFloat("sens");
        Move = Player.GetComponent<Poruszanie>();
        LookP = Player.GetComponent<MouseLook>();
        Cursor.lockState = CursorLockMode.Locked;
        
    }


    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        PlayerPrefs.SetInt("QualityLevel", qDrop.value);
    }


    public void SetVolume(float volume)
    {
        Debug.Log(volume);
        audioMixer.SetFloat("volume", volume);
        PlayerPrefs.SetFloat("vol", volume);
    }
    public void SetSensivity(float sens)
    {
        Debug.Log(sens);
        PlayerPrefs.SetFloat("sens", sens);
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
