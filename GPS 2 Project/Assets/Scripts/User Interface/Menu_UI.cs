using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_UI : MonoBehaviour
{
    public Animator anim;

    public void Start()
    {
    }

    IEnumerator sceneLoad(string name)
    {
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(name);
    }


    public void ExitGame()
    {
        PlayerPrefs.SetInt("HighestScore", 0);
        Application.Quit();
    }

  

    public void LevelSelect_StartGame()
    {
        StartCoroutine(sceneLoad("LevelSelect"));
        //SceneManager.LoadScene("LevelSelect");

    }

    public void ToLevel1()
    {
        LevelManager.n = 0;
        Timer.startTime = 660f;
        Timer.newStartTime = 60f;
        Timer.num = 0;
        JobScore.currScore = 0;

        StartCoroutine(sceneLoad("Level 1"));
    }

    public void BackToMainMenu()
    {
        LevelManager.n = 0;
        Time.timeScale = 1;
        StartCoroutine(sceneLoad("_newMainMenu"));

    }

    public void Level1_Complete()
    {
        LevelManager.n = 0;
        StartCoroutine(sceneLoad("LevelSelect"));
    }

    public void ToCollectionScreen()
    {
        StartCoroutine(sceneLoad("CollectionScreen"));

    }

    public void ToTrophyScreen()
    {
        StartCoroutine(sceneLoad("TrophyScreen"));

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
