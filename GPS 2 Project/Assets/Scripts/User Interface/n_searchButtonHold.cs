using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;


public class n_searchButtonHold : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public GameObject TaskWindow;

    public GameObject player;
    private bool holdButton;
    private float holdButtonTime;

    public float pickUpTime = 10f;
    public UnityEvent onLongClick;
    public Image fillImage;
    public Text text;

    public void OnPointerDown(PointerEventData eventData)
    {
        holdButton = true;

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Reset();
    }

    public void Reset()
    {
        holdButton = false;
        holdButtonTime = 0f;
        fillImage.fillAmount = holdButtonTime / pickUpTime;
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
