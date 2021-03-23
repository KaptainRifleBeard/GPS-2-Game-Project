using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectSpaceCount : MonoBehaviour
{
    public int space;
    public t_itemList itemlist;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "3 seat Sofa")
        {
            itemlist.safe_spacecount = 7;
            space = 7;
        }
        if (other.gameObject.name == "Large wardrobe 2")
        {
            itemlist.safe_spacecount = 10;
            space = 10;
        }
    }

}
