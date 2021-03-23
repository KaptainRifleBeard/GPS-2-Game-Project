using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceDisplay : MonoBehaviour
{
    public Text pocketSpace;
    public Text hideSpace;
    public Text safeSpace;

    public t_itemList list;

    void Start()
    {
        
    }

    void Update()
    {
        if (list.moveToHide == true)
        {
            pocketSpace.text =  list.pocket_spacecount.ToString() + " / 5";
            hideSpace.text = "Space Used: " + list.hide_spacecount.ToString();
        }
        else
        {
            pocketSpace.text = list.pocket_spacecount.ToString() + " / 5";
            safeSpace.text = "Space Used: " + list.safe_spacecount.ToString();

        }

    }
}
