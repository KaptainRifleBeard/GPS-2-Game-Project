using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SearchDisplay : MonoBehaviour
{
    //To check in which level and how many item to pop out
    public ProrgessBar bar;

    public GameObject[] itemList;
    int y;
    int rand;


    void Start()
    {
        y = SceneManager.sceneCount;
        rand = Random.Range(0, itemList.Length);
        Active();

        for (int i = 0; i < rand; i++)
        {
            itemList[i].SetActive(true);

        }
        Active();

    }


    void Update()
    {
        if (y == 1 && bar.showWindow == true)
        {            
            rand = Random.Range(0, itemList.Length);
            Active();

            Debug.Log("list: " + rand);
            if(rand < SearchWindow.totalSafeCount)
            {
                for (int i = 0; i < rand; i++)
                {
                    itemList[i].SetActive(true);

                }
            }
            
        }


    }

    void Active()
    {
        if (rand == 0)
        {
            itemList[0].SetActive(false);
            itemList[1].SetActive(false);
            itemList[2].SetActive(false);
            itemList[3].SetActive(false);
            itemList[4].SetActive(false);
        }
        //set active to false
        if (rand == 1)
        {
            itemList[0].SetActive(true);
            itemList[1].SetActive(false);
            itemList[2].SetActive(false);
            itemList[3].SetActive(false);
            itemList[4].SetActive(false);

        }
        if (rand == 2)
        {
            itemList[0].SetActive(true);
            itemList[1].SetActive(true);
            itemList[2].SetActive(false);
            itemList[3].SetActive(false);
            itemList[4].SetActive(false);
        }
        if (rand == 3)
        {
            itemList[0].SetActive(true);
            itemList[1].SetActive(true);
            itemList[2].SetActive(true);
            itemList[3].SetActive(false);
            itemList[4].SetActive(false);
        }

        if (rand == 4)
        {
            itemList[0].SetActive(true);
            itemList[1].SetActive(true);
            itemList[2].SetActive(true);
            itemList[3].SetActive(true);
            itemList[4].SetActive(false);
        }


        if (rand == 5)
        {
            itemList[0].SetActive(true);
            itemList[1].SetActive(true);
            itemList[2].SetActive(true);
            itemList[3].SetActive(true);
            itemList[4].SetActive(true);
        }

    }
}
