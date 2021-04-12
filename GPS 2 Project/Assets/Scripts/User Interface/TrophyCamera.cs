using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyCamera : MonoBehaviour
{
    public float rotateSpeed = 20;

    public void OnMouseDrag()
    {
        float xPos = Input.GetAxis("Mouse X") * rotateSpeed * Mathf.Deg2Rad;
        float yPos = Input.GetAxis("Mouse Y") * rotateSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -xPos);
        transform.Rotate(Vector3.right, yPos);

    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
