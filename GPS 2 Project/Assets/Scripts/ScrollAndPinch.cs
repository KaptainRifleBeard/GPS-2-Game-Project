using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollAndPinch : MonoBehaviour
{
    public Camera cam;
    protected Plane plane;
    public bool isRotate;

    private void Awake()
    {
        if(cam == null)
        {
            cam = Camera.main;
        }
    }

    void Start()
    {
        
    }


    void Update()
    {
        if(Input.touchCount >= 1)
        {
            plane.SetNormalAndPosition(transform.up, transform.position);
        }

        var delta1 = Vector3.zero;
        var delta2 = Vector3.zero;

        //Scroll
        if(Input.touchCount >= 1)
        {
            delta1 = PlanePositionDelta(Input.GetTouch(0));
            if(Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                cam.transform.Translate(delta1, Space.World);
            }
        }

        //Pinch
        if(Input.touchCount >= 2)
        {
            var pos1 = PlanePosition(Input.GetTouch(0).position);
            var pos2 = PlanePosition(Input.GetTouch(1).position);
            var pos1b = PlanePosition(Input.GetTouch(0).position - Input.GetTouch(0).deltaPosition);
            var pos2b = PlanePosition(Input.GetTouch(1).position - Input.GetTouch(1).deltaPosition);
            
            
            //zoom
            var zoom = Vector3.Distance(pos1, pos2) / 
                       Vector3.Distance(pos1b, pos2b);

            //edge case
            if(zoom == 0 || zoom > 10)
            {
                return;
            }

            //move cam amount the mid ray
            cam.transform.position = Vector3.LerpUnclamped(pos1, cam.transform.position, 1 / zoom);

            if(isRotate && pos2b != pos2)
            {
                cam.transform.RotateAround(pos1, plane.normal, Vector3.SignedAngle(pos2 - pos1, pos2b - pos1b, plane.normal));
            }
        }

        
    }

    protected Vector3 PlanePositionDelta(Touch touch)
    {
        //not moved
        if(touch.phase != TouchPhase.Moved)
        {
            return Vector3.zero;
        }

        //delta
        var rayBefore = cam.ScreenPointToRay(touch.position - touch.deltaPosition);
        var rayNow = cam.ScreenPointToRay(touch.position);
        if(plane.Raycast(rayBefore, out var enterBefore) && plane.Raycast(rayNow, out var enterNow))
        {
            return rayBefore.GetPoint(enterBefore) - rayNow.GetPoint(enterNow);
        }

        //not on plane
        return Vector3.zero;
    }

    protected Vector3 PlanePosition(Vector2 screenPos)
    {
        //position
        var ray = cam.ScreenPointToRay(screenPos);
        if(plane.Raycast(ray, out var enterNow))
        {
            return ray.GetPoint(enterNow);
        }
        return Vector3.zero;
    }
}
