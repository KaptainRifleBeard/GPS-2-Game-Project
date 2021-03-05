using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class t_JobButton : MonoBehaviour
{
    public Button jbutton;
    public Text jname;

    private t_JobData job;
    private t_JobList jobList;



    void Start()
    {
        jbutton.onClick.AddListener(HandleButtonClick);
    }

    public void SetUp_Job(t_JobData currJob, t_JobList currentList)
    {
        job = currJob;
        jname.text = job.title;

        jobList = currentList;
    }

    public void HandleButtonClick()
    {
        
    }

}
