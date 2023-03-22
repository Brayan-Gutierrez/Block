using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pausa : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        if(Time.timeScale==1) {
            Time.timeScale = 0;
        } else {
            Time.timeScale = 1;
            
        }
    }

    //Sirve para detectar cuando se deja de pulsar
    public void OnPointerUp(PointerEventData eventData)
    {
    }

}
