using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearNivel : MonoBehaviour
{
    public GameObject PreBloque;
    public GameObject parentObject;
    public GameObject PrePoder;
   
    public Material[] myMaterials = new Material[5];
    // Para crear bloques random
    
    void Start()
    {
        for(int i = 0; i <(Random.Range(2,69)) ; i++) {

            Instantiate(PreBloque,transform.position, Quaternion.identity,parentObject.transform);
            PreBloque.GetComponent<Renderer>().material = myMaterials[Random.Range(0,myMaterials.Length)];
            
        }
        Instantiate(PrePoder, transform.position, Quaternion.AngleAxis(90, Vector3.forward),  parentObject.transform);
    }

}
