using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Button : MonoBehaviour
{
    public Transform contentPanel_Safe;

    public GameObject TaskBoard;

    public GameObject windowClose;
    public GameObject safe;
    public GameObject hide;

    public bool exitWindow = false;
    public t_itemList itemList;
    public GameObject[] cleanWindow;
    public cleaningTaskButton notClicked;
    public HidingSpot hideSpot;
    public StrikeOut strikeout;

    IEnumerator SetToTrue()
    {
        yield return new WaitForSeconds(0.5f);
        exitWindow = false;
    }

    public void Safe_ExitButton()
    {
        safe.SetActive(false);
        windowClose.SetActive(false);
        exitWindow = true;

        foreach (Transform child in contentPanel_Safe)
        {
            GameObject.Destroy(child.gameObject);
        }
        StartCoroutine(SetToTrue());

    }


    public void Hide_ExitButton()
    {
        hide.SetActive(false);
        windowClose.SetActive(false);

        itemList.moveToHide = false;
        hideSpot.clicked = false;

    }



    public void OpenTaskBoard()
    {
        TaskBoard.SetActive(true);
    }

    public void ExitTaskBoard()
    {
        TaskBoard.SetActive(false);
    }
    public void ExitCleaningWindow()
    {
        for(int i = 0; i < cleanWindow.Length; i++)
        {
            cleanWindow[i].SetActive(false);
            notClicked.clicked = false;
        }
    }


    public void StopGetCaughtBoolean()
    {
        strikeout.GetCaught = false;
    }


}
