using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ReiniciarNivel : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        SceneManager.LoadScene("Level01");
        Time.timeScale = 1;
    }

    //Sirve para detectar cuando se deja de pulsar
    public void OnPointerUp(PointerEventData eventData)
    {
        
    }
}
