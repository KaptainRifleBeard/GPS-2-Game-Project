using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemDisplay : MonoBehaviour
{
    public Text textName;
    public Image sprite;

    public InventoryItem item;

    public void Init(InventoryItem item)
    {
        this.item = item;
        if(textName != null)
        {
            textName.text = item.displayName;
        }
        if (sprite != null)
        {
            sprite.sprite = item.sprite;
        }
    }

    void Start()
    {
        if(item != null)
        {
            Init(item);
        }
    }


    void Update()
    {


    }
}
