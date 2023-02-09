using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public static int puntos = 0;
    public Text textoPunto;

    public GameObject nivelCompletado;
    public GameObject juegoCompletado;

    public SiguienteNivel siguienteNivel;

    public Pelota pelota;
    public Barra barra;

    public Transform contenedorBloques;
    public SonidosFinPartida sonidosFinPartida;

    // Start is called before the first frame update
    void Start()
    {
        ActualizarMarcadorPuntos();
    }

    void ActualizarMarcadorPuntos()
    {
        textoPunto.text = "Puntos: " + Puntos.puntos;
    }

    public void GanarPunto()
    {
        Puntos.puntos++;
        ActualizarMarcadorPuntos();

        if (contenedorBloques.childCount <= 0 ){
            pelota.DetenerMovimiento();
            barra.enabled = false;

            if (siguienteNivel.EsUltimoNivel()){

                juegoCompletado.SetActive(true);
            }
            else
            {
                nivelCompletado.SetActive(true);
            }

            sonidosFinPartida.NivelCompletado();
            
            siguienteNivel.ActivarCarga();
        }
    }
    
}
