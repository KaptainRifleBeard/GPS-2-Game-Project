using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object
{
    public int space;
}

public class ObjectSpaceCount : MonoBehaviour
{
    public List<Object> objectSpace;
    
    public int space;

    void Start()
    {
        
    }


    void Update()
    {
        for(int i = 0; i < objectSpace.Count; i++)
        {
            Object obj = objectSpace[i];

            objectSpace[0].space = 10;
        }
    }
}
