using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Window_Button masterBathWindow;
    public Window_Button bathWindow;
    public Window_Button tableWindow;
    public Window_Button kitchenWindow;
    public StrikeOut strikeOut;
    public Timer timer;

    public t_itemList itemList;

    public GameObject winScreen;

    public GameObject LevelCompleteScreen;
    public Image starImage1;
    public Image wstarImage2;
    public Image wstarImage3;
    public Image wstarImage4;

    public Sprite sStar;
    public static int n = 0;

    public bool completedAllTask;
    public Animator anim, winAnim;
    public Animator animation;

    IEnumerator loadAnimOpen()
    {
        anim.SetInteger("Num", 1);

        yield return new WaitForSeconds(1f);
    }

    IEnumerator loadAnimClose()
    {
        anim.SetInteger("Num", 0);

        yield return new WaitForSeconds(1f);
        LevelCompleteScreen.SetActive(false);


    }

    IEnumerator winOpen()
    {
        winAnim.SetInteger("Num", 1);

        yield return new WaitForSeconds(1f);
    }

    IEnumerator winClose()
    {
        winAnim.SetInteger("Num", 0);

        yield return new WaitForSeconds(1f);
        winScreen.SetActive(false);


    }
    void Start()
    {
        PlayerPrefs.SetInt("Collection", 0);
        PlayerPrefs.SetInt("Level1Star", 0);

    }

    // Update is called once per frame
    void Update()
    {
        //complete all task - level complete screen
        if(n < 1)
        {
            if (masterBathWindow.doneBathroom == true && bathWindow.doneMBathroom == true && tableWindow.doneTable == true
          && kitchenWindow.doneKitchen == true && itemList.gotTheJewl == true)
            {
                LevelCompleteScreen.SetActive(true);
                StartCoroutine(loadAnimOpen());
                winScreen.SetActive(false);

                completedAllTask = true;
                Time.timeScale = 0f;

                PlayerPrefs.SetInt("Collection", 1);
                PlayerPrefs.SetInt("Level1Star", 1);

                starImage1.sprite = sStar;
                n++;
            }
        }

        //complete all task and steal more than rm2000 ( 1 star ) - win screen
        if (masterBathWindow.doneBathroom == true && bathWindow.doneMBathroom == true && tableWindow.doneTable == true
         && kitchenWindow.doneKitchen == true && itemList.gotTheJewl == true && Timer.newStartTime > 180f)
        {
           

            if (JobScore.currScore > 8000)
            { //reset time
                //LevelCompleteScreen.SetActive(false);
                StartCoroutine(loadAnimClose());

                Timer.startTime = 660f;
                Timer.newStartTime = 60f;
                Timer.num = 0;


                //StarSystem.num = 2;
                wstarImage2.sprite = sStar;
                wstarImage3.sprite = sStar;
                PlayerPrefs.SetInt("Level1Star", 2);

                winScreen.SetActive(true);
                StartCoroutine(winOpen());

            }
            else if (JobScore.currScore > 10000)
            { //reset time
                //LevelCompleteScreen.SetActive(false);
                StartCoroutine(loadAnimClose());

                Timer.startTime = 660f;
                Timer.newStartTime = 60f;
                Timer.num = 0;


                wstarImage2.sprite = sStar;
                wstarImage3.sprite = sStar;
                wstarImage4.sprite = sStar;
                PlayerPrefs.SetInt("Level1Star", 3);

                //StarSystem.num = 3;
                winScreen.SetActive(true);
                StartCoroutine(winOpen());

            }
        }

    }



    public void ContinueGame()
    {
        Debug.Log("false ui");
        LevelCompleteScreen.SetActive(false);
        StartCoroutine(loadAnimClose());
        StartCoroutine(winClose());

    }
}
