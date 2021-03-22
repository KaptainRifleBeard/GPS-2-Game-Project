using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleaningTaskButton : MonoBehaviour
{
    public GameObject[] cleaningList;
    public int num;
    public GameObject cleanButton;

    public bool clicked;
    public void onClick()
    {
        clicked = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CleaningTaskObject")
        {
            Debug.Log("Task");
            if (other.gameObject.name == "bowl 1_small")
            {
                cleanButton.SetActive(true);

                //cleaningList[0].SetActive(true);
                num = 1;
            }
            if (other.gameObject.name == "Kitchen Counter")
            {
                cleanButton.SetActive(true);

                //cleaningList[1].SetActive(true);
                num = 2;
            }
            if (other.gameObject.name == "bowl 1")
            {
                cleanButton.SetActive(true);

                //cleaningList[2].SetActive(true);
                num = 3;
            }
            if (other.gameObject.name == "Dining_Table")
            {
                cleanButton.SetActive(true);

                //cleaningList[3].SetActive(true);
                num = 4;
            }
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
