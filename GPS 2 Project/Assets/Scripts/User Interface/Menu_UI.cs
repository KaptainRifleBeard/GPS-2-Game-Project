using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_UI : MonoBehaviour
{
    public void ExitGame()
    {
        PlayerPrefs.SetInt("HighestScore", 0);
        Application.Quit();
    }

    public void SettingMenu()
    {
        //nothing here
    }

    public void LevelSelect_StartGame()
    {
        SceneManager.LoadScene("LevelSelect");

    }

    public void ToLevel1()
    {
        LevelManager.n = 0;
        Timer.startTime = 660f;
        Timer.newStartTime = 60f;
        Timer.num = 0;
        JobScore.currScore = 0;

        SceneManager.LoadScene("Level 1");
    }

    public void BackToMainMenu()
    {
        LevelManager.n = 0;
        SceneManager.LoadScene("_newMainMenu");
    }

    public void Level1_Complete()
    {
        LevelManager.n = 0;
        SceneManager.LoadScene("LevelSelect");
    }

    public void ToCollectionScreen()
    {
        SceneManager.LoadScene("CollectionScreen");
    }


    public void ButtonClick()
    {
        if (SettingAudio.onSFX == false)
        {
            FindObjectOfType<_AudioManager>().Play("ButtonClick", 0.2f);
        }
        else
        {
            FindObjectOfType<_AudioManager>().Play("ButtonClick", 0.0f);
        }
    }
}
