using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    public GameObject loseScreen;

    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {

        }
    }

    public void RetryLevel()
    {
        SceneManager.LoadScene("Level 1");
        loseScreen.SetActive(false);
    }

    public void MainMenu()
    {
        //SceneManager.LoadScene("MainMenu");
        loseScreen.SetActive(false);
    }
}
