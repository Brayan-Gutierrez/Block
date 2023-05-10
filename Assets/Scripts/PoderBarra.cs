using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoderBarra : MonoBehaviour
{
    Vector3 posicionInicial;
    Collider colider;
    public Rigidbody rig;
    public Puntos puntos;
    public GameObject gestor;
    public GameObject barra;
    public Barra barraScript;
    public GameObject pelotaTrans;
    static int i;
   
    void Start()
    {
        posicionInicial.Set(UnityEngine.Random.Range(-14.5f, 14.5f), UnityEngine.Random.Range(-5f, 8.5f), 0);
        transform.position = posicionInicial;
        colider = GetComponent<Collider>();
        gestor = GameObject.Find("GestorDelJuego");
        puntos = (Puntos)gestor.GetComponent("Puntos");
        barra = GameObject.Find("Barra");
        barraScript = (Barra)barra.GetComponent("Barra");
        pelotaTrans = GameObject.Find("Pelota");

    }

    void OnCollisionEnter()
    {
        /*Instantiate(efectoParticulas, transform.position, Quaternion.identity);*/
        colider.isTrigger = true;
        rig.isKinematic = false;
        //rig.AddForce(new Vector3(0, 100, 0));
        //transform.SetParent(null);
        /*puntos.GanarPunto();*/

        //Is Trigger ACTIVADO
        /*Con este metodo la pelota atraviesa bloques 
        los rompe al momento*/

    }

    void OnTriggerEnter(Collider collider)
    {
        if ((collider.gameObject.CompareTag("Player") || collider.gameObject.CompareTag("Suelo")) && i <= 7)
        {
            if (collider.gameObject.CompareTag("Player"))
            {
                if(pelotaTrans.transform.parent)
                {
                    pelotaTrans.transform.SetParent(null);
                    AumentoBarra();
                    pelotaTrans.transform.SetParent(barra.transform);
                }
                else
                {
                    AumentoBarra();
                }

            }

            Destroy(gameObject);
            transform.SetParent(null);
            puntos.ConetoHijos();
            i++;
        }

    }

    public void AumentoBarra()
    {
        barra.transform.localScale = barra.transform.localScale + new Vector3(2, 0, 0);
        barraScript.desplazamiento--;
    }

}
