using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonHold : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    private bool holdButton;
    private float holdButtonTime;

    public float pickUpTime;
    public UnityEvent onLongClick;
    public Image fillImage;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Holding button");
        holdButton = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Not holding button");
        Reset();
    }

    void Reset()
    {
        holdButton = false;
        holdButtonTime = 0f;
        fillImage.fillAmount = holdButtonTime / pickUpTime;
    }

    void Start()
    {
        
    }


    void Update()
    {
        if(holdButton)
        {
            holdButtonTime += Time.deltaTime;
            if(holdButtonTime > pickUpTime)
            {
                if(onLongClick != null)
                {
                    onLongClick.Invoke();
                }
                Reset();
            }
            fillImage.fillAmount = holdButtonTime / pickUpTime;
        }
    }
}
