using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionManager : MonoBehaviour
{
   public GameObject necklaceCollection;

    void Start()
    {
        
    }

    void Update()
    {
        if(StarSystem.num == 1)
        {
            necklaceCollection.SetActive(true);
        }
    }
}
