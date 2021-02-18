using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    //Player Movement
    public Transform player;
    public Rigidbody rb;

    public float moveSpeed;
    Vector3 moveDirection;
    bool stop = false;

    //Joystick
    public RectTransform pad;



    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;

        //Limit the handler drag range
        transform.localPosition = Vector2.ClampMagnitude(eventData.position - (Vector2)pad.position, pad.rect.width * 0.5f);
        moveDirection = new Vector3(transform.localPosition.x, 0, transform.localPosition.y).normalized;
    }

    public void OnPointerUp(PointerEventData eventData)  //back to original position if not drag
    {       
        //add int/bool set to false

        transform.localPosition = Vector3.zero;
        moveDirection = Vector3.zero;
        StopCoroutine(PlayerMove());
        stop = true;


    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //add int/bool set to true
        //Move player
        StartCoroutine(PlayerMove());
        stop = false;
        

    }

    
    IEnumerator PlayerMove()
    {
        while (true)
        {
            player.Translate(moveSpeed * moveDirection * Time.deltaTime, Space.World);

            if (moveDirection != Vector3.zero)
            {
                //Rotate player facing direction
                player.rotation = Quaternion.Slerp(player.rotation, Quaternion.LookRotation(moveDirection), 5 * Time.deltaTime);
            }
            yield return null;
            
        }
        
    }


    void Update()
    {
       if(stop == true)
        {
            StopAllCoroutines();
        }

    }

}
