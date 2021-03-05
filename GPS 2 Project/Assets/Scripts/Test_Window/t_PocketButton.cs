using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class t_PocketButton : MonoBehaviour
{
    public Button pbutton;
    public Text pnameItem;
    public Text pvalueItem;
    public Text pspaceItem;
    //public Image iconItem;

    private t_ItemData item;
    private t_itemList itemList;

    void Start()
    {
        pbutton.onClick.AddListener(HandleButtonClick);
    }

    public void SetUp_Pocket(t_ItemData currentItem, t_itemList currentList)
    {
        item = currentItem;
        pnameItem.text = item.name;
        pvalueItem.text = item.value.ToString();
        pspaceItem.text = item.space.ToString();

        itemList = currentList;
    }

    public void HandleButtonClick()
    {
        GameObject g = GameObject.Find("Content_Safe");
        t_itemList list = g.GetComponent<t_itemList>();

        //itemList.PutInSafe(item.name, item.value, item.space);
        
        if (list.moveToHide == true)
        {
            if(list.hide_spacecount < 20)
            {
                itemList.PutInHide(item);
                itemList.RemovePocketItem(item, itemList);

                Destroy(gameObject);

            }

        }
        else
        {
            itemList.PutInSafe(item);
            itemList.RemovePocketItem(item, itemList);

            Destroy(gameObject);

        }
    }

}
