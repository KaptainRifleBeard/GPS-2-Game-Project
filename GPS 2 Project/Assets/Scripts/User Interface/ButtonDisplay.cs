using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDisplay : MonoBehaviour
{
    public GameObject searchButton;
    public GameObject cleanButton;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            if (gameObject.tag == "CleaningTaskObject")
            {
                Debug.Log("Task");
                cleanButton.SetActive(true);

            }
            else
            {
                searchButton.SetActive(true);

            }

        }
    }
    public void OnCollisionExit(Collision collision)
    {
        searchButton.SetActive(false);
        cleanButton.SetActive(false);

    }


    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
