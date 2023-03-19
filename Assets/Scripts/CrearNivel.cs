using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearNivel : MonoBehaviour
{
    public GameObject PreBloque;
    public GameObject parentObject;
    //Vector3 posicionInicial;
    public Material[] myMaterials = new Material[5];
    // Para crear bloques random
    
    void Start()
    {
        for(int i = 0; i <(Random.Range(2,69)) ; i++) {

            Instantiate(PreBloque,transform.position, Quaternion.identity,parentObject.transform);
            PreBloque.GetComponent<Renderer>().material = myMaterials[Random.Range(0,myMaterials.Length)];
            //posicionInicial.Set(Random.Range(-14.5f,14.5f),Random.Range(-5f,8.5f),0);
            //PreBloque.transform.position=posicionInicial;
            
            //transform.position=posicionInicial;
        }
        
    }

}
