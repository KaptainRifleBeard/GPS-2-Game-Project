using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectSpaceCount : MonoBehaviour
{
    public int space;
    public t_itemList itemlist;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Complimentary coffee table" || other.gameObject.name == "Nightstand(1)" 
            || other.gameObject.name == "Nightstand(2)" || other.gameObject.name == "Nightstand(3)"
            || other.gameObject.name == "Floating Shelve" || other.gameObject.name == "Floating Shelve (1)")
        {
            itemlist.safe_spacecount = 3;
            space = 3;
        }
        if (other.gameObject.name == "LivingRoomShelve")
        {
            itemlist.safe_spacecount = 4;
            space = 4;
        }
        if (other.gameObject.name == "Glass Cabinet" || other.gameObject.name == "Kitchen cabinet countertop")
        {
            itemlist.safe_spacecount = 5;
            space = 5;
        }
        if (other.gameObject.name == "Electronic Safe 2" || other.gameObject.name == "Study room desk" ||
           other.gameObject.name == "Regular size bed" || other.gameObject.name == "TV cabinet")
        {
            itemlist.safe_spacecount = 6;
            space = 6;
        }
        if (other.gameObject.name == "3 seat Sofa" || other.gameObject.name == "Clothes drawer")
        {
            itemlist.safe_spacecount = 7;
            space = 7;
        }
        if (other.gameObject.name == "small wardrobe" || other.gameObject.name == "King sized bed")
        {
            itemlist.safe_spacecount = 8;
            space = 8;
        }
        if (other.gameObject.name == "Large wardrobe 2")
        {
            itemlist.safe_spacecount = 10;
            space = 10;
        }

    }

}
