using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerInput : MonoBehaviour
{
    public bool DisableTouchMouseLink = false;
    bool Tap = false;
    bool DoubleTap = false;

    public float DoubleTapDelta = 0.5f;
    private float LastTappedTime;

    private Vector3 InitialPos;
    private Vector3 EndPos;
    public float Deadzone = 20f;
    public float SwipeDelta = 1f;
    private float LastSwipedTime;

    public float DragSpeed = 1f;

    public float PosTranslateDist = 5f;
    private Transform DefaultPOS_Player;

    public float CamMoveSpeed = 2f;
    private bool CamIsMoving = false;
    public Vector3 newTargetPOS;
    public Plane myPlane;
    public AudioClip[] TapSound;
  
    public void CustomButtonTrigger()
    {
        if(Tap == true)
        {
            Debug.Log("Tapped");
            AudioManager.Instance.RandomSoundEffect(TapSound[0]);

        }
        
        if(DoubleTap == true)
        {
            Debug.Log("DoubleTapped");
            AudioManager.Instance.RandomSoundEffect(TapSound[0]);
        }
       
    }

    void SwipeDirection(Vector3 endPos)
    {
        float xAbs = Math.Abs(endPos.x);
        float yAbs = Math.Abs(endPos.y);

        if(xAbs>yAbs)
        {
            //left right
            if(endPos.x > 0)
            {
                Debug.Log("RIGHT");
                
            }
            else
            {
                Debug.Log("LEFT");
                
            }
        }
        else
        {
            //up down
            if (endPos.y > 0)
            {
                Debug.Log("UP");

            }
            else
            {
                Debug.Log("DOWN");
            }
            
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        DefaultPOS_Player = transform;
        if (DisableTouchMouseLink == true) // to unlink mouse with touch and have separate functions for those inputs
        {
            Input.simulateMouseWithTouches = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
            {
                InitialPos = Input.mousePosition;
                if(Camera.main.orthographic == true)
                {
                    newTargetPOS = Camera.main.ScreenToWorldPoint(InitialPos);
                }
                else
                {
                    Ray ray = Camera.main.ScreenPointToRay(InitialPos);
                    Plane target = new Plane(Vector3.forward, new Vector3(0, 0, 0));
                    float Dist;
                    target.Raycast(ray, out Dist);
                    newTargetPOS = ray.GetPoint(Dist);
                    newTargetPOS.z = Camera.main.transform.position.z;
                }
              
                Tap = true;

                if (Time.time - LastTappedTime < DoubleTapDelta)
                {
                    DoubleTap = true;
                    CamIsMoving = true;
                }
                LastTappedTime = Time.time;
                LastSwipedTime = Time.time;

            CustomButtonTrigger();
        }

            if (Input.GetMouseButton(0))
            {
            EndPos = Input.mousePosition - InitialPos;
            float currRange = Vector3.SqrMagnitude(EndPos);
            if (EndPos != Vector3.zero && currRange > Deadzone)
            {
                Debug.Log("Dragging");

            }
     
            }
            
            if (Input.GetMouseButtonUp(0))
            {
                float currRange = Vector3.SqrMagnitude(EndPos);
                if (EndPos != Vector3.zero && currRange > Deadzone)
                {
                    if (Time.time - LastSwipedTime < SwipeDelta)
                    {
                        Debug.Log("Swiped");
                        SwipeDirection(EndPos);
                    }

                }
                Tap = false;
                DoubleTap = false;
                InitialPos = Vector3.zero;
                EndPos = Vector3.zero;
            }
        

   }

}
