using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCleaning : MonoBehaviour
{
    public Button button;
    public Text jobName;
    //public Image tickImage;

    private CleanJob job;
    private CleaningList joblist;

    void Start()
    {
        button.onClick.AddListener(HandleButtonClick);

    }

    public void SetUp(CleanJob currJob, CleaningList currentList)
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
