using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    public GameObject loseScreen;

    void Update()
    {
        
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
