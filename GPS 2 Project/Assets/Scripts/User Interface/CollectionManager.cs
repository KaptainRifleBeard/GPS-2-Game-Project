using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionManager : MonoBehaviour
{
    public static int num = 0;

    public GameObject necklaceCollection;

    void Start()
    {
        num = PlayerPrefs.GetInt("Collection");

    }

    void Update()
    {
        if(num == 1)
        {
            necklaceCollection.SetActive(true);
        }
    }
}
