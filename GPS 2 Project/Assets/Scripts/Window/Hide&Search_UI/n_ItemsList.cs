using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class n_Item
{
    public string _name;
    public int _value;
    public int _space;
}

public class n_ItemsList : MonoBehaviour
{
    public ProrgessBar bar;
    public HidingSpot hide;

    public List<n_Item> itemList;
    public Transform contentPanel;
    public n_ItemsList otherShop;

    public Text spaceDisplay;

    public n_ButtonItemPool buttonItemPool;
    public int space = 5;


    void Start()
    {
        RefreshDisplay();
    }

    void Update()
    {
       
    }

    public void RefreshDisplay()
    {
        spaceDisplay.text = "Space Left: " + space.ToString(); 
        RemoveButton();
        AddButton();
    }

    public void AddButton()
    {
        int rand = Random.Range(0, 5);
        for (int j = 0; j < rand; j++)
        {

            n_Item item = itemList[j];
            GameObject newButton = buttonItemPool.GetItem();
            newButton.transform.SetParent(contentPanel);

            n_ButtonItem button = newButton.GetComponent<n_ButtonItem>();
            button.SetUp(item, this);
        }
    }

    public void RemoveButton()
    {
        while(contentPanel.childCount > 0)  //if is 0, nonid remove anything
        {
            GameObject toRemove = transform.GetChild(0).gameObject;
            buttonItemPool.ReturnItems(toRemove);
        }
    }

    public void AddItem(n_Item itemToAdd, n_ItemsList panelList)
    {
        panelList.itemList.Add(itemToAdd);
    }

    public void RemoveItem(n_Item itemRemove, n_ItemsList panelList)
    {
        for(int i = panelList.itemList.Count - 1; i >= 0; i--)
        {
            if(panelList.itemList[i] == itemRemove)
            {
                panelList.itemList.RemoveAt(i);
            }
        }
    }

    public void PutItemToOtherWindow(n_Item item)
    {
        if (otherShop.space >= item._space)
        {
            space += item._space;
            otherShop.space -= item._space;

            AddItem(item, otherShop);
            RemoveItem(item, this); //remove item from this window

            RefreshDisplay();
            otherShop.RefreshDisplay();

        }
    }
}
