using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Window_Button masterBathWindow;
    public Window_Button bathWindow;
    public Window_Button tableWindow;
    public Window_Button kitchenWindow;
    public StrikeOut strikeOut;

    public t_itemList itemList;

    public GameObject winScreen;
    public bool completedAllTask;

    void Start()
    {
        PlayerPrefs.SetInt("Level1 star", 0);

    }

    // Update is called once per frame
    void Update()
    {
        if((strikeOut.GetCaught == true && completedAllTask == false) || 
            (completedAllTask == false && Timer.newStartTime > 300f))
        {
            PlayerPrefs.SetInt("Level1 star", 1);
        }


        if (masterBathWindow.doneBathroom == true && bathWindow.doneMBathroom == true && tableWindow.doneTable == true
            && kitchenWindow.doneKitchen == true && itemList.gotTheJewl == false)
        {
            PlayerPrefs.SetInt("Level1 star", 2);

        }

        if (masterBathWindow.doneBathroom == true && bathWindow.doneMBathroom == true && tableWindow.doneTable == true
           && kitchenWindow.doneKitchen == true && itemList.gotTheJewl == true)
        {
            winScreen.SetActive(true);
            completedAllTask = true;
            PlayerPrefs.SetInt("Level1 star", 3);

        }

        if(masterBathWindow.doneBathroom == true && bathWindow.doneMBathroom == true && tableWindow.doneTable == true
           && kitchenWindow.doneKitchen == true && Timer.newStartTime > 300f)
        {
            PlayerPrefs.SetInt("Level1 star", 2);
        }
    }
}
