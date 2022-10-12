using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloques : MonoBehaviour
{
    public GameObject efectoParticulas;

    //Is Trigger DESACTIVADO
    void OnCollisionEnter(){
        Instantiate(efectoParticulas, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    //Is Trigger ACTIVADO
    /* Con este metodo la pelota atraviesa bloques 
    los rompe al momento
    void OnTriggerEnter(){
        Destroy(gameObject);
    }  */
}
