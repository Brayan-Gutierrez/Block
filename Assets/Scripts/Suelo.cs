using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{
    public AudioSource error;
    public Vidas vidas;
    void OnTriggerEnter(Collider collider){
       
        if (collider.gameObject.CompareTag("Pelota"))
        {
            vidas.PerderVida();
            error.Play();
        }

   }

}
