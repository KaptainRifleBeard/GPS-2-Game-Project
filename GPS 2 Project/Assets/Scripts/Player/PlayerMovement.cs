using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Joystick joystick;
    public float speed;
    public  Rigidbody rb;

    //Vector3 direction;
    //private float turnVelocity;
    public Animator animator;
    public n_searchButtonHold holdButton;

    [SerializeField] thirdPersonCamera cam;

    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(joystick.joystickPos.y != 0)
        {

            float heading = Mathf.Atan2(joystick.joystickPos.x, joystick.joystickPos.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, heading, 0f);

            rb.velocity = new Vector3(joystick.joystickPos.x * speed, 0, joystick.joystickPos.y * speed);
            animator.SetBool("isWalk", true);
            animator.SetBool("isIdle", false);
            animator.SetBool("isSearch", false);
            //cam.EndRotate();

        }
        else
        {
            rb.velocity = Vector3.zero;
            NpcMovement.isIdle = true;
            animator.SetBool("isIdle", true);
            animator.SetBool("isWalk", false);
            animator.SetBool("isSearch", false);
        }

        if(holdButton.holdButton == true)
        {
            animator.SetBool("isIdle", false);
            animator.SetBool("isWalk", false);
            animator.SetBool("isSearch", true);
        }
    }
 
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
