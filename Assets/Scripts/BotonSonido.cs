using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BotonSonido : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject imgX;
    public static bool pulsado = false;
    public GameObject gestor;
    public AudioSource musica;

    void Start()
    {
        gestor = GameObject.Find("GestorDelJuego");
        musica = (AudioSource)gestor.GetComponent("AudioSource");
        //musica.enabled = true;
        pulsado = !pulsado;
        ActiDesacSonido();

    }

    public void ActiDesacSonido()
    {
        imgX.SetActive(!pulsado);

        AudioSource[] audios = FindObjectsOfType<AudioSource>();

        if (pulsado == false)
        {
            foreach (AudioSource a in audios)
            {
                a.enabled = false;
            }
        }
        else
        {
            foreach (AudioSource a in audios)
            {
                a.enabled = true;
            }
        }

        pulsado = !pulsado;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ActiDesacSonido();

    }
    public void OnPointerUp(PointerEventData eventData)
    {
    }
}
