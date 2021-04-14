using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class thirdPersonCamera : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float distance;
    [SerializeField] float offsetAngle_x;
    [SerializeField] float offsetAngle_y;

    Vector3 m_offset;
     float xPos;
    const float yPos = 45;

    bool isRotating = false; //check is rotate?
    const float angle = Mathf.PI / 180;

    const float MAX_ANGLE_Y = 45;
    const float MIN_ANGLE_Y = 45;

    Transform myTransform;
    public Joystick joystick;

    public Transform mineTransform
    {
        get
        {
            if (myTransform == null)
            {
                myTransform = this.transform;
            }
            return myTransform;
        }
    }

    GameObject myGameObject;
    public GameObject mineGameObject
    {
        get
        {
            if (myGameObject == null)
            {
                myGameObject = this.gameObject;
            }
            return myGameObject;
        }
    }


    void Start()
    {
        CalculateOffset();
    }

    void Update()
    {
        if (isRotating)
        {
            CalculateOffset();
        }


    }

    void LateUpdate()
    {
        mineTransform.position = target.position + m_offset;
        mineTransform.LookAt(target);

        
    }

    void CalculateOffset()
    {
        m_offset.y = distance * Mathf.Sin(offsetAngle_y * angle);
        float newRadius = distance * Mathf.Cos(offsetAngle_y * angle);

        m_offset.x = newRadius * Mathf.Sin(offsetAngle_x * angle);
        m_offset.z = -newRadius * Mathf.Cos(offsetAngle_x * angle);
    }

    public void StartRotate()
    {
        isRotating = true;

        xPos = offsetAngle_x;
    }


    public void Rotate(float x, float y)
    {
        if (x != 0)
        {
            offsetAngle_x += x;
        }
        if (y != 0)
        {
            offsetAngle_y += y;

            offsetAngle_y = offsetAngle_y > MAX_ANGLE_Y ? MAX_ANGLE_Y : offsetAngle_y;
            offsetAngle_y = offsetAngle_y < MIN_ANGLE_Y ? MIN_ANGLE_Y : offsetAngle_y;
        }



    }

    public void EndRotate(bool isNeedReset = true)
    {
        isRotating = false;

        if (isNeedReset)
        {
            offsetAngle_y = 45;
            offsetAngle_x = 0;
            CalculateOffset();
        }
    }
}
