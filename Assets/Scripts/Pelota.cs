using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public float velocidadInicial = 600f;
    public Rigidbody rig;
    bool enJuego = false;
    Vector3 posicionInicial;
    public Transform barra;

    void Start()//guarda la posicion incial para resetear
    {
        posicionInicial = transform.position;
    }
    
    public void Reset(){//resetea la posicion inicial del objeto
        transform.position = posicionInicial;
        transform.SetParent(barra);
        enJuego = false;
        DetenerMovimiento();
    }

    // Start is called before the first frame update

    public void DetenerMovimiento(){
        rig.isKinematic = true;
        rig.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(!enJuego && Input.GetButtonUp("Fire1")){
            enJuego = true;
            transform.SetParent(null);
            rig.isKinematic = false;
            rig.AddForce(new Vector3(velocidadInicial,velocidadInicial,0));
        }
    }
}
