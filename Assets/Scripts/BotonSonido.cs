using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BotonSonido : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject imgX;
    public bool pulsado=false;
    public GameObject gestor;
    public AudioSource musica;


    // Start is called before the first frame update
    void Start()
    {
        gestor = GameObject.Find("GestorDelJuego");
        musica = (AudioSource)gestor.GetComponent("AudioSource");
        //musica.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerDown(PointerEventData eventData)
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
    public void OnPointerUp(PointerEventData eventData)
    {
    }
}
