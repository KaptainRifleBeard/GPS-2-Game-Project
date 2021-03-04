using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class CleanJob
{
    public Sprite tickbox;
    public string _description;
}


public class CleaningList : MonoBehaviour
{
    public Button button;
    //public Sprite tickBoxImage;

    public List<CleanJob> cleanList;

    public Transform contentPanel;
    public ButtonCleaningPool buttonItemPool;

    public void RefreshDisplay()
    {
        RemoveButton();
        AddJob();
    }


    public void AddJob()
    {
        int rand = Random.Range(2, cleanList.Count);
        for (int j = 0; j < rand; j++)
        {

            CleanJob job = cleanList[j];
            GameObject newButton = buttonItemPool.GetJob();
            newButton.transform.SetParent(contentPanel, false);

            ButtonCleaning button = newButton.GetComponent<ButtonCleaning>();
            button.SetUp(job, this);

        }
    }
    public void RemoveButton()
    {
        while (contentPanel.childCount > 0)  //if is 0, nonid remove anything
        {
            GameObject toRemove = transform.GetChild(0).gameObject;
            buttonItemPool.ReturnItems(toRemove);
        }
    }

    public void AddItem(CleanJob itemToAdd, CleaningList panelList)
    {
        panelList.cleanList.Add(itemToAdd);
    }

    public void RemoveItem(CleanJob itemRemove, CleaningList panelList)
    {
        for (int i = panelList.cleanList.Count - 1; i >= 0; i--)
        {
            if (panelList.cleanList[i] == itemRemove)
            {
                panelList.cleanList.RemoveAt(i);
            }
        }
    }


    public void PutToOtherWindow(CleanJob job)
    {
        Debug.Log("yamete!");
    }

    void Start()
    {
        RefreshDisplay();

    }


    void Update()
    {

    }
}