using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ReiniciarNivel : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Puntos puntos;
    public BotonSonido botonSonido;
    public void OnPointerDown(PointerEventData eventData)
    {
        puntos.PuntosReinicio();
        SceneManager.LoadScene("Level01");
        Time.timeScale = 1;
        
    }

    //Sirve para detectar cuando se deja de pulsar
    public void OnPointerUp(PointerEventData eventData)
    {
        
    }
}
