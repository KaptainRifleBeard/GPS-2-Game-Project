using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleaningTaskButton : MonoBehaviour
{
    public GameObject[] cleaningList;
    public int num;
    public GameObject cleanButton;

    public bool CollideWithHide;
    public bool collideWithSearchObject;
    public bool collideWithCleaningTask;


    public bool clicked;
    public void onClick()
    {
        clicked = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CleaningTaskObject")
        {
            collideWithCleaningTask = true;
            Debug.Log("Task");
            if (other.gameObject.name == "toilet bowl (1)")
            {
                cleanButton.SetActive(true);
                num = 1;
            }
            if (other.gameObject.name == "Cleaning_Puddle")
            {
                cleanButton.SetActive(true);
                num = 2;
            }
            if (other.gameObject.name == "Clean Master Bedroom")
            {
                cleanButton.SetActive(true);
                num = 3;
            }
            if (other.gameObject.name == "Dining_Table")
            {
                cleanButton.SetActive(true);
                num = 4;
            }
        }
        if (other.gameObject.tag == "Hiding Spot")
        {
            CollideWithHide = true;
        }
        if (other.gameObject.tag == "InteractableObject")
        {
            collideWithSearchObject = true;
        }


    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(clicked)
        {
            if (num == 1)
            {
                cleaningList[0].SetActive(true);
            }
            if (num == 2)
            {
                cleaningList[1].SetActive(true);

            }
            if (num == 3)
            {
                cleaningList[2].SetActive(true);

            }
            if (num == 4)
            {
                cleaningList[3].SetActive(true);

            }
        }
        
    }
}
