using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonHold : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public GameObject player;
    private bool holdButton;
    private float holdButtonTime;

    public float pickUpTime;
    public UnityEvent onLongClick;
    public Image fillImage;

    public InteractableItem closeToTarget;
    public float chanceToGetMoney;

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
        int randNum = Random.Range(0, 100); // 100% total for determining loot chance;;
        int rand = Random.Range(0, 50);

        if (holdButton)
        {
            holdButtonTime += Time.deltaTime;
            if (holdButtonTime > pickUpTime)
            {
                if (onLongClick != null)
                {
                    onLongClick.Invoke();
                }
                Reset();

                if(rand > 0 && rand <= 25)
                {
                    Debug.Log("You get " + randNum + " coins");
                }
                if(rand > 26 && rand <= 50)
                {
                    Debug.Log("This thing is cheap");
                }
            }
            fillImage.fillAmount = holdButtonTime / pickUpTime;
        }
        

        
    }
}
