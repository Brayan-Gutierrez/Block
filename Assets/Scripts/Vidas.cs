using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    //static define la variable como unica en todo el programa
    public static int vidas =3;
    public Text textoVidas;
    public Pelota pelota;
    public Barra barra;
    void Start()
    {
        textoVidas.text = "Vidas: " + Vidas.vidas;
    }

    void ActualizarMarcadorVidas(){
        textoVidas.text = "Vidas: " + Vidas.vidas;
    }

    public void PerderVida(){
        Vidas.vidas--;
        ActualizarMarcadorVidas();
        barra.Reset();
        pelota.Reset();
    }

}
