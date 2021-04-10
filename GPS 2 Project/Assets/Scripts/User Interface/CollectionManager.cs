using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionManager : MonoBehaviour
{
    public static int num = 0;

    public GameObject necklaceCollection;

    void Start()
    {
        num = PlayerPrefs.GetInt("Level1 star");

    }

    void Update()
    {
        if(num == 1)
        {
            necklaceCollection.SetActive(true);
        }
    }
}
