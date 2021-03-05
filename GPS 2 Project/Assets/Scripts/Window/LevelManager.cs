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

    public t_itemList itemList;

    void Start()
    {
        masterBathWindow.GetComponent<Window_Button>();
    }

    // Update is called once per frame
    void Update()
    {

        if (masterBathWindow.doneMBathroom == true && bathWindow.doneBathroom == true && tableWindow.doneTable == true && kitchenWindow.doneKitchen == true && itemList.gotTheJewl == true)
        {
            SceneManager.LoadScene("Level1_CompleteScreen");
        }
    }
}