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
            pocketSpace.text = "Space Used: " + list.pocket_spacecount.ToString();
            hideSpace.text = "Space Used: " + list.hide_spacecount.ToString();
        }
        else
        {
            pocketSpace.text = "Space Used: " + list.pocket_spacecount.ToString();
            safeSpace.text = "Space Used: " + list.safe_spacecount.ToString();

        }

    }
}
