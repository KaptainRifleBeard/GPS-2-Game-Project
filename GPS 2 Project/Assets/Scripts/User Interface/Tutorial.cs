using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject[] tutorial;
    public int counter;
    public GameObject gameTask;
    public GameObject progressBar;
    public GameObject pocket;

    static public bool tutorialTrigg;
    static public bool tutorialTrigg1;
    static public bool tutorialTrigg2;
    public bool tutorial1;
    public bool tutorial2;
    public bool tutorial3;
    public bool tutorial4;
    bool phase2done = false;
    bool phase3done = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        counter = 0;

        tutorial[0].SetActive(true);
        gameTask.SetActive(false);
        tutorialTrigg = false;
        tutorialTrigg1 = false;
        tutorialTrigg2 = false;
        tutorial1 = true;
        tutorial2 = false;
        tutorial3 = false;
        tutorial4 = false;

        for (int i = 1; i < tutorial.Length; i++)
        {
            tutorial[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Touched");
            counter += 1;
        }

        //phase 1 tutorial

        if(tutorial1 == true)
        {
            for (int i = 0; i < 7; i++)
            {
                if (counter == i)
                {
                    tutorial[i].SetActive(true);
                }
                else
                {
                    tutorial[i].SetActive(false);
                }
            }

            if(counter > 6)
            {
                tutorial1 = false;
                Time.timeScale = 1f;
            }
        }
        
        

        if(counter == 3)
        {
            gameTask.SetActive(true);
        }

        if(counter == 5)
        {
            gameTask.SetActive(false);
        }

        if(tutorialTrigg == true)
        {
            counter = 7;
            tutorial2 = true;
            tutorialTrigg = false;
        }

        //phase 2 tutorial
        if(tutorial2 == true)
        {
            Time.timeScale = 0f;
            for (int i = 0; i < 10; i++)
            {
                if (counter == i)
                {
                    tutorial[i].SetActive(true);
                }
                else
                {
                    tutorial[i].SetActive(false);
                }
            }

            if(counter == 8)
            {
                progressBar.SetActive(true);
            }
            else
            {
                progressBar.SetActive(false);
            }

            if (counter > 9)
            {
                tutorial2 = false;
                phase2done = true;
                Time.timeScale = 1f;
            }
        }

        if (tutorialTrigg1 == true)
        {
            counter = 10;
            tutorial3 = true;
            tutorialTrigg1 = false;
        }

        //phase 3 tutorial
        if (tutorial3 == true && phase2done == true)
        {
            Time.timeScale = 0f;
            for (int i = 0; i < 12; i++)
            {
                if (counter == i)
                {
                    tutorial[i].SetActive(true);
                }
                else
                {
                    tutorial[i].SetActive(false);
                }
            }

            if(counter == 11)
            {
                pocket.SetActive(true);
            }
            else
            {
                pocket.SetActive(false);
            }

            if (counter > 11)
            {
                tutorial3 = false;
                phase3done = true;
                Time.timeScale = 1f;
            }
        }

        if (tutorialTrigg2 == true)
        {
            counter = 12;
            tutorial4 = true;
            tutorialTrigg2 = false;
        }

        //phase 4 tutorial
        if (tutorial4 == true && phase3done == true)
        {
            Time.timeScale = 0f;
            for (int i = 0; i < 14; i++)
            {
                if (counter == i)
                {
                    tutorial[i].SetActive(true);
                }
                else
                {
                    tutorial[i].SetActive(false);
                }
            }

            if (counter > 13)
            {
                tutorial4 = false;
                Time.timeScale = 1f;
            }
        }
    }
}
