using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    //Player Movement
    public Transform player;
    public float moveSpeed;
    Vector3 moveDirection;

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
        transform.localPosition = Vector3.zero;
        moveDirection = Vector3.zero;
        StopCoroutine(PlayerMove());
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Move player
        StartCoroutine(PlayerMove());
    }

    IEnumerator PlayerMove()
    {

        while (true)
        {
            player.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);

            if (moveDirection != Vector3.zero)
            {
                //Rotate player facing direction
                player.rotation = Quaternion.Slerp(player.rotation, Quaternion.LookRotation(moveDirection), 5 * Time.deltaTime);
            }

            yield return null;
        }
    }

    
}
