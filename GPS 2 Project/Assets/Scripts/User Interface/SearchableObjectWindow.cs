using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchableObjectWindow : MonoBehaviour
{
    public Text spaceText;

    public int spaceAvailable;
    public int maxSpace = 20;

    void Start()
    {
        
    }


    void Update()
    {
        spaceText.GetComponent<Text>().text = spaceAvailable.ToString() + " / " + maxSpace.ToString();

    }
}
