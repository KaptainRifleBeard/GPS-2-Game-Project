using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class t_JobData
{
    public string title;

}

public class t_JobList : MonoBehaviour
{

    public GameObject jobButton;

    public Transform contentPanel_Job;
    public List<t_JobData> jobList;


    public void AddJob()
    {
        for (int j = 0; j < jobList.Count; j++)
        {
            t_JobData job = jobList[j];
            GameObject newButton = Instantiate(jobButton, transform.parent);
            newButton.transform.SetParent(contentPanel_Job);

            t_JobButton button = newButton.GetComponent<t_JobButton>();
            button.SetUp_Job(job, this);
        }


        
    }



    void Start()
    {
        AddJob();
    }


    void Update()
    {
        
    }
}
