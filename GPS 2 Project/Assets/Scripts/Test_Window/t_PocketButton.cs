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
    public Image iconItem;

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
        iconItem.sprite = item.objImage;

        itemList = currentList;
    }

    public void HandleButtonClick()
    {
        //itemList.PutInSafe(item.name, item.value, item.space);
        
        if (itemList.moveToHide == true)
        {
            if(itemList.hide_spacecount < 21)
            {
                itemList.PutInHide(item);
                itemList.RemovePocketItem(item, itemList);
            
                Destroy(gameObject);

            }

            if(item.name == "Gold and Jade Necklace")
            {
                itemList.gotTheJewl = true;
            }
        }
        else
        {
            itemList.PutInSafe(item);
            itemList.RemovePocketItem(item, itemList);
            JobScore.currScore -= item.value;

            Destroy(gameObject);

        }


    }

}
