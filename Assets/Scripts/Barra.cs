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
    public int desplazamiento = 14;
    

    void Start()
    {
        posicionInicial = transform.position;
    }

    public void  Reset() 
    {
        transform.position = posicionInicial;
        //transform.localScale;
    }

    void Update()
    {
        direccion = botonIzquierdo.pulsado ? -1 : (botonDerecho.pulsado ? 1 : Input.GetAxisRaw("Horizontal"));
        float posX = transform.position.x + (direccion * velocidad * Time.deltaTime); 
       
       transform.position = new Vector3(Mathf.Clamp(posX, -(desplazamiento), desplazamiento), transform.position.y, transform.position.z);

        /* Estas lineas hacen los mismo que Mathf.Clamp y sustituye el posX  
        if(posX>8) posX=8;
        if(posX<-8) posX=-8;
        */

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
    }
}
