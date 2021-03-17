using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class Window_Button : MonoBehaviour
{
    public GameObject kitchenWindow;
    public GameObject masterbathWindow;
    public GameObject bathWindow;
    public GameObject tableWindow;
    public GameObject player;
    private bool holdButton;


    public float holdButtonTime;
    public float pickUpTime = 10f;

    public Image fillImage;
    public Text text;


    public t_CleaningList1 list;
    public t_CleaningList cleanList;

    public bool doneKitchen;
    public bool doneTable;
    public bool doneMBathroom;
    public bool doneBathroom;

    public bool completedCleaningTask;

    public void OnPointerDown()
    {
        Debug.Log(holdButton);
        holdButton = true;

    }

    public void OnPointerUp()
    {
        Reset();
    }

    void Reset()
    {
        holdButton = false;
        holdButtonTime = 0f;
        fillImage.fillAmount = holdButtonTime / pickUpTime;
    }


    void Update()
    {
        if (holdButton)
        {
            if (list.num == 1)
            {
                if (holdButtonTime < pickUpTime)
                {
                    holdButtonTime += Time.deltaTime;
                    fillImage.fillAmount = holdButtonTime / pickUpTime;

                }
                else
                {
                    text.text = "Done";
                    doneMBathroom = true;
                }
            }

            if (list.num == 2)
            {
                if (holdButtonTime < pickUpTime)
                {
                    holdButtonTime += Time.deltaTime;
                    fillImage.fillAmount = holdButtonTime / pickUpTime;

                }
                else
                {
                    text.text = "Done";
                    doneKitchen = true;
                }
            }

            if (list.num == 3)
            {
                if (holdButtonTime < pickUpTime)
                {
                    holdButtonTime += Time.deltaTime;
                    fillImage.fillAmount = holdButtonTime / pickUpTime;

                }
                else
                {
                    text.text = "Done";
                    doneBathroom = true;
                }
            }
            if (list.num == 4)
            {

                if (holdButtonTime < pickUpTime)
                {
                    holdButtonTime += Time.deltaTime;
                    fillImage.fillAmount = holdButtonTime / pickUpTime;

                }
                else
                {
                    text.text = "Done";
                    doneTable = true;
                }
            }

        }

        if(doneBathroom == true && doneKitchen == true && doneMBathroom == true && doneTable == true)
        {
            completedCleaningTask = true;
        }

    }


    public void ExitWindow()
    {
        kitchenWindow.SetActive(false);
        bathWindow.SetActive(false);
        masterbathWindow.SetActive(false);
        tableWindow.SetActive(false);
    }
}