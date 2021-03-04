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
        itemList.PutInPocket(item.name, item.value, item.space);
        itemList.RemoveHideItem(item, itemList);

        Destroy(gameObject);
    }
}
