using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiguienteNivel : MonoBehaviour
{
    public string nivelCargar;
    public float retraso;

    [ContextMenu("Activar Carga")]
    public void ActivarCarga(){
        Invoke("CargarNivel", retraso);
    }

    void CargarNivel(){
        Application.LoadLevel(nivelCargar);
    }

    public bool EsUltimoNivel(){
        /*Estas lineas se reemplazan con la linea 29
        if(nivelCargar == "Portada"){
            return true;
        }
        else{
            return false;
        }
        */
        return nivelCargar == "Portada";
    }
}
