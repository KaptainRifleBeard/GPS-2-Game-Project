using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PocketCount : MonoBehaviour
{
    public Text pocketCount;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pocketCount.text = SearchWindow.totalSafeCount.ToString() + " / " + SearchWindow.maxPocket.ToString();


    }

}
