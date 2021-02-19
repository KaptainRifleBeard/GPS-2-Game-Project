using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollAndPinch : MonoBehaviour
{
    public float rotateSpeed = 50f;
    private float pitch = 0.0f;
    private int invertPos = 1;
    private float yaw = 0.0f;
            
    void Rotate()
    {
        pitch += Input.GetTouch(0).deltaPosition.y * rotateSpeed * invertPos * Time.deltaTime;
        yaw += Input.GetTouch(0).deltaPosition.x * rotateSpeed * invertPos * Time.deltaTime;

        pitch = Mathf.Clamp(pitch, -90, -90);

        this.transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

    }

}
