using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonHold : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
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
        //Debug.Log("Holding button");
        holdButton = true;

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("Not holding button");
        Reset();
    }

    void Reset()
    {
        holdButton = false;
        holdButtonTime = 0f;
        fillImage.fillAmount = holdButtonTime / pickUpTime;
    }


    

    void Update()
    {

        if (holdButton)
        {
            if(holdButtonTime < pickUpTime)
            {
                text.text = "Cleaning......";

                holdButtonTime += Time.deltaTime;
                fillImage.fillAmount = holdButtonTime / pickUpTime;

            }
            else
            {
                text.text = "Done";
                TaskWindow.SetActive(false);
            }
        }
        

        
    }
}
