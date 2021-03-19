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

    public bool stop = false;
    public t_itemList itemList;

    IEnumerator SetToTrue()
    {
        yield return new WaitForSeconds(0.5f);
        stop = false;
    }

    public void Safe_ExitButton()
    {
        safe.SetActive(false);
        windowClose.SetActive(false);
        stop = true;

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
