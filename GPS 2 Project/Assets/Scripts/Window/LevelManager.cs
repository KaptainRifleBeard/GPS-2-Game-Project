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
    public Image starImage2;
    public Image starImage3;

    public Sprite sStar;
    public static int n = 0;


    public bool completedAllTask;

    void Start()
    {
        PlayerPrefs.SetInt("Level1 star", 0);

    }

    // Update is called once per frame
    void Update()
    {
        if((strikeOut.GetCaught == true && completedAllTask == false) || 
            (completedAllTask == false && Timer.newStartTime > 300f))
        {
            PlayerPrefs.SetInt("Level1 star", 1);

        }


        if (masterBathWindow.doneBathroom == true && bathWindow.doneMBathroom == true && tableWindow.doneTable == true
            && kitchenWindow.doneKitchen == true && itemList.gotTheJewl == false)
        {
            //PlayerPrefs.SetInt("Level1 star", 2);

        }

        //complete all task

        if(n < 1)
        {
            if (masterBathWindow.doneBathroom == true && bathWindow.doneMBathroom == true && tableWindow.doneTable == true
          && kitchenWindow.doneKitchen == true && itemList.gotTheJewl == true && Timer.newStartTime > 180f)
            {
                LevelCompleteScreen.SetActive(true);
                completedAllTask = true;
                Time.timeScale = 0f;

                PlayerPrefs.SetInt("Level1 star", 1);
                starImage1.sprite = sStar;
                n++;
            }
        }
       

        if(completedAllTask == true && Timer.newStartTime > 300f)
        {
            //reset time
            LevelCompleteScreen.SetActive(false);

            Timer.startTime = 660f;
            Timer.newStartTime = 60f;
            Timer.num = 0;

            winScreen.SetActive(true);
            PlayerPrefs.SetInt("Level1 star", 1);

        }

        //complete all task and steal more than rm2000 ( 1 star )
        //complete all task and steal more than rm10000 ( 2 star )
        //complete all task and steal more than rm12000 ( 3 star )


        if (masterBathWindow.doneBathroom == true && bathWindow.doneMBathroom == true && tableWindow.doneTable == true
           && kitchenWindow.doneKitchen == true && Timer.newStartTime > 180)
        {
            PlayerPrefs.SetInt("Level1 star", 2);

        }
    }
    public void ContinueGame()
    {
        Debug.Log("false ui");
        LevelCompleteScreen.SetActive(false);
    }
}
