using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Button : MonoBehaviour
{
    public GameObject TaskBoard;

    public GameObject windowClose;
    public GameObject safe;
    public GameObject hide;

    public void Safe_ExitButton()
    {
        Debug.Log("button click");
        safe.SetActive(false);
        windowClose.SetActive(false);
    }
    public void Hide_ExitButton()
    {
        Debug.Log("button click");
        hide.SetActive(false);
        windowClose.SetActive(false);
    }

    public void OpenTaskBoard()
    {
        TaskBoard.SetActive(true);
    }

    public void ExitTaskBoard()
    {
        TaskBoard.SetActive(false);
    }

   
}
