using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myCamera : MonoBehaviour
{
    public float xAxis;
    public float yAxis;
    public float rotationSensitivity = 5f;

    public Transform target;
    public float rotateMin = -40f;
    public float rotateMax = 80f;
    public float smoothTime = 0.15f;

    Vector3 targetRotation;
    Vector3 currentVal;

    public Joystick joystick;

    void Start()
    {
        
    }


    void LateUpdate()
    {
        yAxis += Input.GetAxisRaw("Mouse X") * rotationSensitivity;
        xAxis -= Input.GetAxisRaw("Mouse Y") * rotationSensitivity;

        xAxis = Mathf.Clamp(xAxis, rotateMin, rotateMax);
        targetRotation = Vector3.SmoothDamp(targetRotation, new Vector3(xAxis, yAxis), ref currentVal, smoothTime);
        transform.eulerAngles = targetRotation;

        transform.position = target.position - transform.forward * 200f;
    }
}
