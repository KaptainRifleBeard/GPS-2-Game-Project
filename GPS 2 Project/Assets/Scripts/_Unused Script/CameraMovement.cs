using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Joystick joystick;

    public Camera cam;
    public Transform target;

    private Vector3 prevPos;
    public Vector3 offset;

    void Start()
    {

    }

    void Update()
    {
        
        if (joystick.joystickPos.y == 0)
        {
           
            if (Input.GetMouseButtonDown(0))
            {
                prevPos = cam.ScreenToViewportPoint(Input.mousePosition);

            }

            if (Input.GetMouseButton(0)) //drag
            {
                Vector3 direction = prevPos - cam.ScreenToViewportPoint(Input.mousePosition);

                cam.transform.Rotate(new Vector3(1, 0, 0), direction.y * 180);
                cam.transform.Rotate(new Vector3(0, 1, 0), -direction.x * 180, Space.World);

                prevPos = cam.ScreenToViewportPoint(Input.mousePosition);

            }
        }
        else
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(cam.transform.position, desiredPosition, 1.0f);
            cam.transform.position = smoothedPosition;

            cam.transform.LookAt(target);

            
        }
    }

}
