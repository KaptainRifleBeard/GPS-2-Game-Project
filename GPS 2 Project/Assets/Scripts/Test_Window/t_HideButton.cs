using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class t_HideButton : MonoBehaviour
{
    public Button hbutton;
    public Text hnameItem;
    public Text hvalueItem;
    public Text hspaceItem;
    //public Image iconItem;

    private t_ItemData item;
    private t_itemList itemList;


    void Start()
    {
        hbutton.onClick.AddListener(HandleButtonClick);
    }

    public void SetUp_Hide(t_ItemData currentItem, t_itemList currentList)
    {
        item = currentItem;
        hnameItem.text = item.name;
        hvalueItem.text = item.value.ToString();
        hspaceItem.text = item.space.ToString();

        itemList = currentList;
    }

    public void HandleButtonClick()
    {
        GameObject g = GameObject.Find("Content_Safe");
        t_itemList list = g.GetComponent<t_itemList>();

        if (list.pocket_spacecount < 5)
        {
            list.pocket_spacecount += item.space;
            list.hide_spacecount -= item.space;


            itemList.PutInPocket(item);
            itemList.RemoveHideItem(item, itemList);

            Destroy(gameObject);
        }
            
    }
}
