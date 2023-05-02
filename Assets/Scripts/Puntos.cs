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
    int puntosReinicio;

    void Start()
    {
        ActualizarMarcadorPuntos();
        puntosReinicio = puntos;
    }

    void ActualizarMarcadorPuntos()
    {
        textoPunto.text = "Puntos: " + Puntos.puntos;
    }

    public void PuntosReinicio()
    {
        puntos = puntosReinicio;
    }

    public void ConetoHijos()
    {
        if (contenedorBloques.childCount <= 0)
        {
            pelota.DetenerMovimiento();
            barra.enabled = false;

            if (siguienteNivel.EsUltimoNivel())
            {

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

    public void GanarPunto()
    {
        Puntos.puntos++;
        ActualizarMarcadorPuntos();
        ConetoHijos();
    }
    
}
