using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{
    public float velocidad = 20.0f;

    Vector3 posicionInicial;

    public ElementoInteractivo botonIzquierdo;
    public ElementoInteractivo botonDerecho;
    float direccion;

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
    }

    public void  Reset() 
    {
        transform.position = posicionInicial;    
    }

    // Update is called once per frame
    void Update()
    {
        /* Forma altenra de la intruccion siguiente
        if(botonIzquierdo.pulsado)
        {
            direccion = -1;
        }else if(botonDerecho.pulsado)
        {
            direccion = 1;
        }
        else
        {
            direccion = Input.GetAxisRaw("Horizontal");
        }*/
 
        direccion = botonIzquierdo.pulsado ? -1 : (botonDerecho.pulsado ? 1 : Input.GetAxisRaw("Horizontal"));
        
        float posX = transform.position.x + (direccion * velocidad * Time.deltaTime); 
       /* Estas lineas hacen los mismo que Mathf.Clamp y sustituye el posX  
       if(posX>8) posX=8;
       if(posX<-8) posX=-8;
       */
       transform.position = new Vector3(Mathf.Clamp(posX, -14, 14),/*posX*/ transform.position.y, transform.position.z);
       
    }
}
