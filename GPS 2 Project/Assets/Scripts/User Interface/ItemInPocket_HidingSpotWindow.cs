using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInPocket_HidingSpotWindow : MonoBehaviour
{
    public Text n;
    public Text value;
    public Text space;

    public Text pocketName;
    public Text pocketValue;
    public Text pocketSpace;

    public Text h_pocketName;
    public Text h_pocketValue;
    public Text h_pocketSpace;

    bool isPut;

    void Start()
    {
        
    }


    void Update()
    {
        pocketName.text = n.text;
        pocketValue.text = value.text;
        pocketSpace.text = space.text;

    }

    public void PutButton()
    {
        isPut = true;
        if (HidingSpotWindow.currCapacity > 0)
        {
            h_pocketName.text = pocketName.text;
            h_pocketValue.text = pocketValue.text;
            h_pocketSpace.text = pocketSpace.text;

            pocketName.text = " ";
            pocketValue.text = " ";
            pocketSpace.text = " ";
            isPut = false;
        }

        
        if (HidingSpotWindow.currCapacity < 0)
        {
            HidingSpotWindow.currCapacity = 0;
        }
    }
}
