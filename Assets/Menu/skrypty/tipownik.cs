using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class tipownik : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject tip;

    public void OnPointerEnter(PointerEventData eventData)
    {
        tip.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tip.SetActive(false);
    }

    
    void Start()
    {
        tip.SetActive(false);
    }

}
