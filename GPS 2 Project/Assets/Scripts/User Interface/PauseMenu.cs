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
        pauseMenuUi.SetActive(false);


    }

    IEnumerator loadSettingOpen()
    {
        anim.SetInteger("Num", 2);
        Time.timeScale = 1f;

        yield return new WaitForSeconds(1f);
        Time.timeScale = 0f;

    }

    IEnumerator loadSettingClose()
    {
        anim.SetInteger("Num", 3);
        Time.timeScale = 1f;

        yield return new WaitForSeconds(1f);
        SettingScreen.SetActive(false);
    }

    IEnumerator sceneLoad(string name)
    {
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(name);
    }


    public void Resume()
    {
        Time.timeScale = 1f;


        StartCoroutine(loadAnimClose());
        GameIsPaused = false;

    }

    public void Pause()
    {
        pauseMenuUi.SetActive(true);

        StartCoroutine(loadAnimOpen());
        GameIsPaused = true;

    }

    public void ToMainMenu()
    {
        //StartCoroutine(sceneLoad("_newMainMenu"));
        SceneManager.LoadScene("_newMainMenu");


    }

    public void ToSettingScreen()
    {
        SettingScreen.SetActive(true);
        StartCoroutine(loadSettingOpen());


    }

    public void BackToPauseMenu()
    {
        StartCoroutine(loadSettingClose());
        Pause();
    }


}
