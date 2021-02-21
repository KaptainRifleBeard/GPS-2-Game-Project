using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    public GameObject loseScreen;
    public GameObject retryLevelScreen;


    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            retryLevelScreen.SetActive(true);
        }
    }

    public void RetryLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
        loseScreen.SetActive(false);
        retryLevelScreen.SetActive(false);
    }

    public void MainMenu()
    {
        //SceneManager.LoadScene("MainMenu");
        loseScreen.SetActive(false);
        retryLevelScreen.SetActive(false);
    }
}
