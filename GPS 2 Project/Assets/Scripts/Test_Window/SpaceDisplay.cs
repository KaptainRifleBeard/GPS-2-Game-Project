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
    public ObjectSpaceCount player_ObjectSpace;

    void Start()
    {
        
    }

    void Update()
    {
        if (list.moveToHide == true)
        {
            pocketSpace.text =  list.pocket_spacecount.ToString() + " / 5";
            hideSpace.text = list.hide_spacecount.ToString() + " / 20";
        }
        else
        {
            pocketSpace.text = list.pocket_spacecount.ToString() + " / 5";
            safeSpace.text = list.safe_spacecount.ToString() + " / " +  player_ObjectSpace.space.ToString();

        }

    }
}
