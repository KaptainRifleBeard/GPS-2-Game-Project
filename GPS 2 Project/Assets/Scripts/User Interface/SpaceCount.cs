using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceCount : MonoBehaviour
{
    public Text spaceCount;

    void Start()
    {

    }
    
    void Update()
    {
        spaceCount.text = SearchWindow.num.ToString() + " / " + SearchWindow.maxPocket.ToString();

    }



}
