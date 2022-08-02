using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public float velocidadInicial = 600f;
    Rigidbody rig;
    bool enJuego = false;

    void Awake() {

        rig = GetComponent<Rigidbody>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!enJuego && Input.GetButtonUp("Fire1")){
            enJuego = true;
            transform.SetParent(null);
        }
    }
}
