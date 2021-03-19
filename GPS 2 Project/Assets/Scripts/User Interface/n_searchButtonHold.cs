using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class n_searchButtonHold : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool holdButton = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("holding");
        holdButton = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("release button");
        holdButton = false;
    }


    void Update()
    {

    }
}
