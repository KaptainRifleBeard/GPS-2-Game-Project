using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class n_ButtonItem : MonoBehaviour
{
    public Button button;
    public Text nameItem;
    public Text valueItem;
    public Text spaceItem;
    //public Image iconItem;

    private n_Item item;
    private n_ItemsList iemList;
    private n_HideItemList hideiemList;

    void Start()
    {
        button.onClick.AddListener(HandleButtonClick);
    }

    public void SetUp(n_Item currentItem, n_ItemsList currentList)
    {
        item = currentItem;
        nameItem.text = item._name;
        valueItem.text = item._value.ToString();
        spaceItem.text = item._space.ToString();

        iemList = currentList;
    }

    public void SetUpHiding(n_Item currentItem, n_HideItemList currentList)
    {
        item = currentItem;
        nameItem.text = item._name;
        valueItem.text = item._value.ToString();
        spaceItem.text = item._space.ToString();

        hideiemList = currentList;
    }

    public void HandleButtonClick()
    {
        iemList.PutItemToOtherWindow(item);
    }
}
