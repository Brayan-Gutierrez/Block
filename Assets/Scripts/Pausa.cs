using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pausa : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject MenuPausa;

    public void OnPointerDown(PointerEventData eventData)
    {
        if(Time.timeScale==1) {
            Time.timeScale = 0;
            MenuPausa.SetActive(true);
        } else {
            Time.timeScale = 1;
            MenuPausa.SetActive(false);

        }
    }

    //Sirve para detectar cuando se deja de pulsar
    public void OnPointerUp(PointerEventData eventData)
    {
    }

}
