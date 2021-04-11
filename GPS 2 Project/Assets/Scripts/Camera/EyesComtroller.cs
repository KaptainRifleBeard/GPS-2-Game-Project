using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class EyesComtroller : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] thirdPersonCamera cam;

    const float dragAngle = 0.07f;
    Vector2 prevPosition;
    float angleX, angleY;

    Image eyeImg;

    void Start()
    {
        eyeImg = GetComponent<Image>();
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void OnDrag(PointerEventData eventData)
    {
        angleX = (eventData.position.x - prevPosition.x) * dragAngle;
        cam.Rotate(-angleX);
        prevPosition = eventData.position;

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        prevPosition = eventData.position;
        cam.StartRotate();
        eyeImg.color = Color.gray;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        cam.EndRotate(true);
    }
}

