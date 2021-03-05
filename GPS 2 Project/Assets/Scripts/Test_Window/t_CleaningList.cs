using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class t_CleanData
{
    public string title;

}
public class t_CleaningList : MonoBehaviour
{
    public List<t_CleanData> cleanList;


    public GameObject cleanButton;
    public Transform contentPanel_Clean;

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


    void Start()
    {
        AddCleanTask();
    }


    void Update()
    {
        
    }
}
