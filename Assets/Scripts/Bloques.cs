using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloques : MonoBehaviour
{
    public GameObject efectoParticulas;
    public Puntos puntos;
    Vector3 posicionInicial;
    public GameObject gestor;

    void Start() {
        posicionInicial.Set(Random.Range(-14.5f,14.5f),Random.Range(-5f,8.5f),0);
        transform.position=posicionInicial;

        gestor = GameObject.Find("GestorDelJuego");
        puntos = (Puntos)gestor.GetComponent("Puntos");
    }

    //Is Trigger DESACTIVADO
    void OnCollisionEnter(){
        Instantiate(efectoParticulas, transform.position, Quaternion.identity);
        Destroy(gameObject);
        transform.SetParent(null);
        puntos.GanarPunto();
    }

    //Is Trigger ACTIVADO
    /* Con este metodo la pelota atraviesa bloques 
    los rompe al momento
    void OnTriggerEnter(){
        Destroy(gameObject);
    }  */
}
