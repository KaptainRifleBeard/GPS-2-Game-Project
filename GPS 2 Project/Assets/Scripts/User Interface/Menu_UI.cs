using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_UI : MonoBehaviour
{
    public void ExitGame()
    {
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
        SceneManager.LoadScene("Level 1");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("_newMainMenu");
    }
}
