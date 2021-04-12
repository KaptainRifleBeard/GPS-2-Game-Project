using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUi;
    public GameObject LevelCompleteScreen;
    public GameObject SettingScreen;

    public Animator anim;

    IEnumerator loadAnimOpen()
    {
        anim.SetInteger("Num", 1);

        yield return new WaitForSeconds(1f);
        Time.timeScale = 0f;
    }

    IEnumerator loadAnimClose()
    {
        anim.SetInteger("Num", 0);

        yield return new WaitForSeconds(1f);
        Time.timeScale = 1f;


    }

    IEnumerator sceneLoad(string name)
    {
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(name);
    }


    public void Resume()
    {

        StartCoroutine(loadAnimClose());
        GameIsPaused = false;
        pauseMenuUi.SetActive(false);

    }

    public void Pause()
    {
        StartCoroutine(loadAnimOpen());
        pauseMenuUi.SetActive(true);
        GameIsPaused = true;

    }

    public void ToMainMenu()
    {
        StartCoroutine(sceneLoad("_newMainMenu"));


    }

    public void ToSettingScreen()
    {
        SettingScreen.SetActive(true);

    }

    public void BackToPauseMenu()
    {
        SettingScreen.SetActive(false);

    }
}
