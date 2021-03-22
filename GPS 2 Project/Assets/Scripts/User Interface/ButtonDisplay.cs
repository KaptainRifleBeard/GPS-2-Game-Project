using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDisplay : MonoBehaviour
{
    public Transform target;

    public GameObject searchButton;
    public GameObject cleanButton;
    public GameObject hideButton;

    static public bool tutorialcheck = false;
    static public bool tutorialcheck1 = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Vector3.Distance(transform.position, target.position) < 200)
            {
                if (gameObject.name == "Cleaning cart (Hiding spot)")
                {
                    hideButton.SetActive(true);
                }
                else if (gameObject.tag == "CleaningTaskObject")
                {
                    Debug.Log("Task");
                    if (tutorialcheck1 == false)
                    {
                        Tutorial.tutorialTrigg2 = true;
                        tutorialcheck1 = true;
                    }
                    cleanButton.SetActive(true);

                }
                else
                {
                    Debug.Log("Enter");
                    if (tutorialcheck == false)
                    {
                        Tutorial.tutorialTrigg = true;
                        tutorialcheck = true;
                    }
                    searchButton.SetActive(true);

                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("player exit");
            searchButton.SetActive(false);
            cleanButton.SetActive(false);
            hideButton.SetActive(false);
        }
           
    }

    void Start()
    {
        tutorialcheck = false;
        tutorialcheck1 = false;
    }


    void Update()
    {
       
    }
}
