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

    void Start()
    {
        y = SceneManager.sceneCount;
       
    }


    void Update()
    {

        if(bar.showWindow == true)
        {
            if(y == 1)
            {
                int rand = Random.Range(1, 4);
                for (int i = 0; i < rand; i++)
                {
                    itemList[i].SetActive(true);
                }
            }
           
        }
    }
}
