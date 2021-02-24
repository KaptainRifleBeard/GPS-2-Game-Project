using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcRotate : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        transform.rotation = Quaternion.Euler(-90f, -90f, -90f);
    }
}
