using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class JobDescription
{
    public Sprite tickbox;
    public string _description;
}


public class JobList : MonoBehaviour
{
    public Button button;
    //public Sprite tickBoxImage;

    public List<JobDescription> jobList;

    public Transform contentPanel;
    public ButtonJobPool buttonItemPool;
    public void RefreshDisplay()
    {
        RemoveButton();
        AddJob();
    }


    public void AddJob()
    {
        int rand = Random.Range(2, jobList.Count);
        for (int j = 0; j < rand; j++)
        {

            JobDescription job = jobList[j];
            GameObject newButton = buttonItemPool.GetJob();
            newButton.transform.SetParent(contentPanel, false);

            buttonJob button = newButton.GetComponent<buttonJob>();
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

    public void AddItem(JobDescription itemToAdd, JobList panelList)
    {
        panelList.jobList.Add(itemToAdd);
    }

    public void RemoveItem(JobDescription itemRemove, JobList panelList)
    {
        for (int i = panelList.jobList.Count - 1; i >= 0; i--)
        {
            if (panelList.jobList[i] == itemRemove)
            {
                panelList.jobList.RemoveAt(i);
            }
        }
    }


    public void PutToOtherWindow(JobDescription job)
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
