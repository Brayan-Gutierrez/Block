using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pausa : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if(Time.timeScale==1) {
            Time.timeScale = 0;
        } else {
            Time.timeScale = 1;
            
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
