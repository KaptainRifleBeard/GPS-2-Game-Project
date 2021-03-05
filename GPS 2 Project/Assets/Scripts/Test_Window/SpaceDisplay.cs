using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceDisplay : MonoBehaviour
{
    public Text pocketSpace;
    public Text hideSpace;
    public Text safeSpace;

    
    void Start()
    {
        
    }

    void Update()
    {
        GameObject g = GameObject.Find("Content_Safe");
        t_itemList list = g.GetComponent<t_itemList>();


        pocketSpace.text = "Space Used: " +  list.pocket_spacecount.ToString();
        hideSpace.text = "Space Used: " + list.hide_spacecount.ToString();
        safeSpace.text = "Space Used: " + list.safe_spacecount.ToString();

    }
}
