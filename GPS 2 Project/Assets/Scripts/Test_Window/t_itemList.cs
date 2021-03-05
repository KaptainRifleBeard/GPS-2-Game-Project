using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public bool showJew = false;

    public int pocket_spacecount = 0;
    public int hide_spacecount = 0;
    public int safe_spacecount = 6;

    //to show how much space left
    public Text pocketSpace;
    public Text hideSpace;
    public Text safeSpace;

    public void t_AddSafeButton() //to show random list
    {
        if(!showJew)
        {
            int rand = Random.Range(0, item_safe.Count);

            for (int j = 0; j < Random.Range(0, rand); j++)
            {
                t_ItemData item = item_safe[j];
                GameObject newButton = Instantiate(safeButton, transform.parent);
                newButton.transform.SetParent(contentPanel_Safe);

                t_ButtonItem button = newButton.GetComponent<t_ButtonItem>();
                button.SetUp(item, this);
            }
        }
        else
        {
            for (int j = 15; j < item_safe.Count; j++)  //jade is [16], [15] + [1] = [16]
            {
                t_ItemData item = item_safe[j];
                GameObject newButton = Instantiate(safeButton, transform.parent);
                newButton.transform.SetParent(contentPanel_Safe);

                t_ButtonItem button = newButton.GetComponent<t_ButtonItem>();
                button.SetUp(item, this);
            }

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

    public void RemoveHideItem(t_ItemData itemRemove, t_itemList panelList) 
    {
        for (int i = panelList.item_hide.Count - 1; i >= 0; i--)
        {
            if (panelList.item_hide[i] == itemRemove)
            {
                panelList.item_hide.RemoveAt(i);
            }
        }
    }

    public void RemovePocketItem(t_ItemData itemRemove, t_itemList panelList) 
    {
        for (int i = panelList.item_pocket.Count - 1; i >= 0; i--)
        {
            if (panelList.item_pocket[i] == itemRemove)
            {
                panelList.item_pocket.RemoveAt(i);

            }

        }
    }



    public void PutInPocket(t_ItemData item)
    {
        item_pocket.Add(item);

        GameObject newButton = Instantiate(pocketButton, transform.parent);
        newButton.transform.SetParent(contentPanel_Pocket);

        t_PocketButton button = newButton.GetComponent<t_PocketButton>();
        button.SetUp_Pocket(item, this);

    }




    public void PutInSafe(t_ItemData item)
    {
        pocket_spacecount -= item.space;
        safe_spacecount += item.space;

        item_safe.Add(item);
        GameObject newButton = Instantiate(safeButton, transform.parent);
        newButton.transform.SetParent(contentPanel_Safe);

        t_ButtonItem button = newButton.GetComponent<t_ButtonItem>();
        button.SetUp(item, this);

    }


    public void PutInHide(t_ItemData item)
    {
        if(hide_spacecount < 20)
        {
            pocket_spacecount -= item.space;
            hide_spacecount += item.space;

            item_hide.Add(item);
            GameObject newButton = Instantiate(hideButton, transform.parent);
            newButton.transform.SetParent(contentPanel_Hide);

            t_HideButton button = newButton.GetComponent<t_HideButton>();
            button.SetUp_Hide(item, this);
        }
        
        
    }



    public void RefreshDisplay()
    {
        t_AddSafeButton();
    }

    void Start()
    {
        RefreshDisplay();

    }


    void Update()
    {
        pocketSpace.text = pocket_spacecount.ToString();
        hideSpace.text = hide_spacecount.ToString();
        safeSpace.text = safe_spacecount.ToString();


        if (Input.GetKeyDown(KeyCode.Space)) //random searchable object display
        {
            RefreshDisplay();
        }

        if (Input.GetKeyDown(KeyCode.V)) //open hiding spot
        {
            moveToHide = true;
        }

        if (Input.GetKeyDown(KeyCode.B)) //change it to recognise name "Master room"
        {
            showJew = true;
            RefreshDisplay();
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
