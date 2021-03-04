using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t_itemList : MonoBehaviour
{
    public List<t_ItemData> item_pocket;
    public List<t_ItemData> item_safe;
    public List<t_ItemData> item_hide;


    public GameObject safeButton;
    public GameObject pocketButton;
    public GameObject hideButton;

    public Transform contentPanel_Safe;
    public Transform contentPanel_Pocket;
    public Transform contentPanel_Hide;

    public bool moveToHide = false;

    public void t_AddSafeButton() //to show random list
    {
        int rand = Random.Range(0, 5);
        for (int j = 0; j < item_safe.Count; j++)
        {
            t_ItemData item = item_safe[j];
            GameObject newButton = Instantiate(safeButton, transform.parent);
            newButton.transform.SetParent(contentPanel_Safe);

            t_ButtonItem button = newButton.GetComponent<t_ButtonItem>();
            button.SetUp(item, this);
        }
    }



    public void RemoveSafeItem(t_ItemData itemRemove, t_itemList panelList)
    {
        for (int i = panelList.item_safe.Count - 1; i >= 0; i--)
        {
            if (panelList.item_safe[i] == itemRemove)
            {
                panelList.item_safe.RemoveAt(i);
            }
        }
    }

    public void RemoveHideItem(t_ItemData itemRemove, t_itemList panelList)  //to hiding spot
    {
        for (int i = panelList.item_hide.Count - 1; i >= 0; i--)
        {
            if (panelList.item_hide[i] == itemRemove)
            {
                panelList.item_hide.RemoveAt(i);
            }
        }
    }

    public void RemovePocketItem(t_ItemData itemRemove, t_itemList panelList)  //to hiding spot
    {
        for (int i = panelList.item_pocket.Count - 1; i >= 0; i--)
        {
            if (panelList.item_pocket[i] == itemRemove)
            {
                panelList.item_pocket.RemoveAt(i);
            }
        }
    }



    public void PutInPocket(string item_name, int item_val, int item_space)
    {
        t_ItemData item = new t_ItemData();

        item_pocket.Add(item);
        item_pocket[item_pocket.Count - 1].name = item_name;
        item_pocket[item_pocket.Count - 1].space = item_val;
        item_pocket[item_pocket.Count - 1].value = item_space;


        GameObject newButton = Instantiate(pocketButton, transform.parent);
        newButton.transform.SetParent(contentPanel_Pocket);

        t_PocketButton button = newButton.GetComponent<t_PocketButton>();
        button.SetUp_Pocket(item, this);

    }




    public void PutInSafe(t_ItemData item)
    {
        item_safe.Add(item);
        GameObject newButton = Instantiate(safeButton, transform.parent);
        newButton.transform.SetParent(contentPanel_Safe);

        t_ButtonItem button = newButton.GetComponent<t_ButtonItem>();
        button.SetUp(item, this);
    }


    public void PutInHide(t_ItemData item)
    {
        item_hide.Add(item);
        GameObject newButton = Instantiate(hideButton, transform.parent);
        newButton.transform.SetParent(contentPanel_Hide);

        t_HideButton button = newButton.GetComponent<t_HideButton>();
        button.SetUp_Hide(item, this);
        
    }



    public void RefreshDisplay()
    {
        t_AddSafeButton();
    }

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //open hiding spot
        {
            RefreshDisplay();
        }

        if (Input.GetKeyDown(KeyCode.V)) //open hiding spot
        {
            moveToHide = true;
        }
    }
}




/*
public void PutInPocket()
{
    foreach (t_ItemData i in item_safe)
    {
        item_pocket.Add(i);
    }

}


public void PutInSafe()
{
    foreach(t_ItemData i in item_pocket)
    {
        item_safe.Add(i);

    }
}
*/
