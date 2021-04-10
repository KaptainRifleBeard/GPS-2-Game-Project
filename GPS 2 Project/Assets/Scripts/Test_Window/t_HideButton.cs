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
    public Image iconItem;

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
        iconItem.sprite = item.objImage;

        itemList = currentList;
    }

    public void HandleButtonClick()
    {
        if (itemList.pocket_spacecount < 5)
        {
            itemList.pocket_spacecount += item.space;
            itemList.hide_spacecount -= item.space;


            itemList.PutInPocket(item);
            itemList.RemoveHideItem(item, itemList);

            Destroy(gameObject);
        }
            
    }
}
