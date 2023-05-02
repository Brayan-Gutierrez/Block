using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public float velocidadPelota = 600f;
    public Rigidbody rig;
    bool enJuego = false;
    Vector3 posicionInicial;
    public Transform barra;

    public ElementoInteractivo pantalla;

    void Start()//guarda la posicion incial para resetear
    {
        posicionInicial = transform.position;
    }

    public void Reset() {//resetea la posicion inicial del objeto
        transform.position = posicionInicial;
        transform.SetParent(barra);
        enJuego = false;
        DetenerMovimiento();
    }

    public void DetenerMovimiento() {
        rig.isKinematic = true;
        rig.velocity = Vector3.zero;
    }

    /*Correcion de pOsicion
    public void ComprobarPosicion()
    {
        if (posicionCompararX == transform.position.x || posicionCompararY == transform.position.y)
        {
            Debug.Log("Correcion posicion");
        }
    }

    
    IEnumerator Esperar()
    {
        yield return new WaitForEndOfFrame();
        //Debug.Log("Se ejecuoto");
        posicionComparar1X = transform.position.x;
        posicionComparar1Y = transform.position.y;

    }
    */
    /*Intento de correcion de velocidad
    public void VelocidadMinima()
    {
        if (rig.velocity.x > -12 && rig.velocity.x < 12)
        {
            Debug.Log("Entro");  
            rig.AddForce((rig.velocity.x / 12*600), 0, 0);
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        /*Intento de correcion de velocidad
        velociInstantanea =rig.velocity.x;
        velociInstantanea1 =rig.velocity.y;
        if (enJuego == true && rig.isKinematic ==false){
            VelocidadMinima();
        }
        */
        /*/*Correcion de pOsicion
        if(enJuego == true)
        {
            posicionCompararX = transform.position.x;
            posicionCompararY = transform.position.y;
            StartCoroutine("Esperar");

        }
        */
        if (!enJuego && (Input.GetButtonUp("Fire1") || pantalla.pulsado)){
            enJuego = true;
            transform.SetParent(null);
            rig.isKinematic = false;
            rig.AddForce(new Vector3(velocidadPelota,velocidadPelota,0));
            
        }

    }
}
