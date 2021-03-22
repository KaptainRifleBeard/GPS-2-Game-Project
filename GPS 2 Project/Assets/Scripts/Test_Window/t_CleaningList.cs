using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class t_CleanData
{
    public string title;
    public Sprite tick;

}
public class t_CleaningList : MonoBehaviour
{
    public List<t_CleanData> cleanList;

    public t_CleaningList1 list;
    public GameObject cleanButton;
    public Transform contentPanel_Clean;

    public Window_Button taskButton;

    public void RefreshDisplay()
    {
        AddCleanTask();
    }


    public void AddCleanTask()
    {
        for (int j = 0; j < cleanList.Count; j++)
        {
            t_CleanData clean = cleanList[j];
            GameObject newButton = Instantiate(cleanButton, transform.parent);
            newButton.transform.SetParent(contentPanel_Clean);

            t_CleanButton button = newButton.GetComponent<t_CleanButton>();
            button.SetUp_Clean(clean, this);
        }

    }
    public void RemoveButton()
    {
       
    }

    public void RemoveCleanTask(t_CleanData itemRemove, t_CleaningList panelList)
    {
        for (int i = panelList.cleanList.Count - 1; i >= 0; i--)
        {
            if (panelList.cleanList[i] == itemRemove)
            {
                panelList.cleanList.RemoveAt(i);
            }
        }
    }


    void Start()
    {
        AddCleanTask();
    }


    void Update()
    {

    }
}
