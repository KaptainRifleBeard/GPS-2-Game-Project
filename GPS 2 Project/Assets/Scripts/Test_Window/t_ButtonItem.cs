using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class t_ButtonItem : MonoBehaviour
{
    public Button sbutton;
    public Text snameItem;
    public Text svalueItem;
    public Text sspaceItem;
    //public Image iconItem;

    private t_ItemData item;
    private t_itemList itemList;



    void Start()
    {
        sbutton.onClick.AddListener(HandleButtonClick);
    }

    public void SetUp(t_ItemData currentItem, t_itemList currentList)
    {
        item = currentItem;
        snameItem.text = item.name;
        svalueItem.text = item.value.ToString();
        sspaceItem.text = item.space.ToString();

        itemList = currentList;
    }

    public void HandleButtonClick()
    {
        GameObject g = GameObject.Find("Content_Safe");
        t_itemList list = g.GetComponent<t_itemList>();

        if(list.pocket_spacecount < 6)
        {
            list.pocket_spacecount += item.space;
            list.safe_spacecount -= item.space;
            JobScore.currScore += item.value;

            itemList.PutInPocket(item); //pocket to safe
            itemList.RemoveSafeItem(item, itemList); //safe to pocket

            Destroy(gameObject);
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
