using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{
    public AudioSource error;
    public Vidas vidas;
    void OnTriggerEnter(){
       vidas.PerderVida();
       error.Play();
   }

/*   void OnCollisionEnter(){
        Debug.Log("Pelota");
    }*/

}
