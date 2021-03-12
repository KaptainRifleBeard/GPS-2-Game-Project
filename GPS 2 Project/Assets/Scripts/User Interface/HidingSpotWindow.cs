using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HidingSpotWindow : MonoBehaviour
{
    public Text currentCap;
    public t_itemList list;


    void Start()
    {
        
    }


    void Update()
    {
        currentCap.text = list.hide_spacecount.ToString() + " / " + 20.ToString();
        //currentCap.text = currCapacity.ToString() + " / " + maxCapacity.ToString();

    }
}
