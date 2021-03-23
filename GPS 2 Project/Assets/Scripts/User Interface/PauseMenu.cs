using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUi;
    public GameObject LevelCompleteScreen;

    public void Resume()
    {
        Debug.Log("false ui");

        LevelCompleteScreen.SetActive(false);

        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }
            
    public void ToMainMenu()
    {
        LevelManager.n = 0;
        SceneManager.LoadScene("_newMainMenu");


    }
}
