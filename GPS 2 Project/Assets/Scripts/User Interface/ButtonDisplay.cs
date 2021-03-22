using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDisplay : MonoBehaviour
{
    public Transform target;

    public GameObject searchButton;
    public GameObject cleanButton;
    public GameObject hideButton;

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
                    cleanButton.SetActive(true);
                    
                }
                else
                {
                    Debug.Log("Enter");
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
        
    }


    void Update()
    {
       
    }
}
