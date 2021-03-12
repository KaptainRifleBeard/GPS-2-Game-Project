using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonJob : MonoBehaviour
{
    public Button button;
    public Text jobName;
    //public Image tickImage;

    private JobDescription job;
    private JobList joblist;

    void Start()
    {
        button.onClick.AddListener(HandleButtonClick);

    }

    public void SetUp(JobDescription currJob, JobList currentList)
    {
        job = currJob;
        jobName.text = job._description;

        joblist = currentList;
    }

    public void HandleButtonClick()
    {
        joblist.PutToOtherWindow(job);
    }

   
}
