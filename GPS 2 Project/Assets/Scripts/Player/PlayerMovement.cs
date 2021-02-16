using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /*
    public float moveSpeed = 0.5f;
    public float drag = 0.5f;
    public float rotateSpeed = 25.0f;
    public Vector3 MoveVector { set; get; }

    public Rigidbody rb;
    public Joystick joystick;
    
    public Vector3 PoolInput()
    {
        Vector3 direction = Vector3.zero;

        direction.x = joystick.Horizontal();
        direction.z = joystick.Vertical();

        if (direction.magnitude > 1)
        {
            direction.Normalize();
        }
        return direction;
    }

    public void Movement()
    {
        rb.AddForce(MoveVector * moveSpeed);
    }

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.maxAngularVelocity = rotateSpeed;
        rb.drag = drag;
    }


    void Update()
    {
        MoveVector = PoolInput();
        Movement();
    }
    */
}
