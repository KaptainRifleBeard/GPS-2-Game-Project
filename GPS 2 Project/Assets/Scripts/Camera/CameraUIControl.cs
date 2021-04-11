using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraUIControl : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] Transform target;
    [SerializeField] thirdPersonCamera cam;
    public Joystick joystick;

    const float dragAngle = 0.07f;


    Vector2 prevPosition;
    float angleX, angleY;


    public void OnBeginDrag(PointerEventData eventData)
    {
        prevPosition = eventData.position;
        cam.StartRotate();
    }

    public void OnDrag(PointerEventData eventData)
    {
        angleX = (eventData.position.x - prevPosition.x) * dragAngle;
        angleY = (eventData.position.y - prevPosition.y) * dragAngle;
        cam.Rotate(-angleX, -angleY);
        //target.Rotate(new Vector3(0, angleX, 0));
        prevPosition = eventData.position;

    }

    public void OnEndDrag(PointerEventData eventData)
    {         
        //cam.EndRotate();

    }
}

