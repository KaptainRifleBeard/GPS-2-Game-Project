using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class t_CleanButton : MonoBehaviour
{
    public Button cbutton;
    public Text cname;

    private t_CleanData cleanTask;
    private t_CleaningList cleanList;


    
    void Start()
    {
        cbutton.onClick.AddListener(HandleButtonClick);
    }

    public void SetUp_Clean(t_CleanData currTask, t_CleaningList currentList)
    {
        cleanTask = currTask;
        cname.text = cleanTask.title;

        cleanList = currentList;
    }

    public void HandleButtonClick()
    {

    }


    void Update()
    {
        
    }
}
