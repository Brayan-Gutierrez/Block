using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{
    public float velocidad = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float tecladoHorizontal = Input.GetAxisRaw("Horizontal");
       float posX = transform.position.x + (tecladoHorizontal * velocidad * Time.deltaTime); 
       if(posX>8) posX=8;
       if(posX<-8) posX=-8;
       transform.position = new Vector3(/*Mathf.Clamp(posX, -8, 8),*/posX, transform.position.y, transform.position.z);
       
    }
}
