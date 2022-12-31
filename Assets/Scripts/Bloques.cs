using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloques : MonoBehaviour
{
    public GameObject efectoParticulas;
    public Puntos puntos;

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
