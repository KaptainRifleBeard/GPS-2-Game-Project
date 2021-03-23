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
    static public bool tutorialcheck3 = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Vector3.Distance(transform.position, target.position) < 200)
            {
                if (gameObject.name == "Cleaning cart (Hiding spot)")
                {
                    hideButton.SetActive(true);
                    if (tutorialcheck3 == false)
                    {
                        Tutorial.tutorialTrigg1 = true;
                        tutorialcheck3 = true;
                    }
                }
                else if (gameObject.tag == "CleaningTaskObject")
                {
                    if (tutorialcheck1 == false)
                    {
                        Tutorial.tutorialTrigg2 = true;
                        tutorialcheck1 = true;
                    }
                    cleanButton.SetActive(true);

                }
                else
                {

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
