using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Button : MonoBehaviour
{
    public Transform contentPanel_Safe;

    public GameObject TaskBoard;

    public GameObject windowClose;
    public GameObject safe;
    public GameObject hide;
    public GameObject LoseScreen_YesNo;
    public GameObject getCaughtScreen;

    public GameObject[] cleanWindow;

    public bool exitWindow = false;


    public t_itemList itemList;
    public cleaningTaskButton notClicked;
    public HidingSpot hideSpot;
    public StrikeOut strikeout;
    public ObjectSpaceCount player_spacecount;

    public Animator anim;
    IEnumerator loadAnimOpen()
    {
        anim.SetInteger("Num", 1);

        yield return new WaitForSeconds(1f);
    }

    IEnumerator loadAnimClose()
    {
        anim.SetInteger("Num", 0);

        yield return new WaitForSeconds(1f);
        TaskBoard.SetActive(false);


    }



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

        if (itemList.gotTheJewl == false && itemList.showJew == true)
        {
            itemList.i = 0;
        }
        itemList.showJew = false;
        itemList.sum = 0;

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
        StartCoroutine(loadAnimOpen());

    }

    public void ExitTaskBoard()
    {
        StartCoroutine(loadAnimClose());
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
        LevelManager.n = 0;
    }

    public void LoseScreenCheck_ToMainMenuYes()
    {
        LevelManager.n = 0;
        LoseScreen_YesNo.SetActive(true);
    }

    public void LoseScreenCheck_ToMainMenuNo()
    {
        strikeout.currStrike = 0;
        LoseScreen_YesNo.SetActive(false);
    }

    public void isRetryLevel()
    {
        strikeout.currStrike = 0;
        LevelManager.n = 0;
        getCaughtScreen.SetActive(false);
    }
}
