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
    public GameObject gameOver;
    public SiguienteNivel siguienteNivel;
    public SonidosFinPartida sonidosFinPartida;

    void Start()
    {
        textoVidas.text = "X " + Vidas.vidas;
    }

    void ActualizarMarcadorVidas(){
        textoVidas.text = "X " + Vidas.vidas;
    }

    public void PerderVida(){
        if (vidas <=0 ) return;

        Vidas.vidas --;
        ActualizarMarcadorVidas();

        if (vidas <= 0){

            //Mostraremos GameOver
            sonidosFinPartida.GameOver();
            gameOver.SetActive(true);
            pelota.DetenerMovimiento();
            barra.enabled = false;

            siguienteNivel.nivelCargar = "Portada";
            siguienteNivel.ActivarCarga();
        }
        else{

            barra.Reset();
            pelota.Reset();
    
        }
    }
}