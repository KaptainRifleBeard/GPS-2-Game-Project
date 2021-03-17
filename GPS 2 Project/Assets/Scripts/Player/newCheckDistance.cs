using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newCheckDistance : MonoBehaviour
{
    public Transform player;

    //To highlight object
    public Material highlightMat;
    public Material defaultMat;
    public Renderer mat;
    public GameObject searchButton;
    public GameObject cleanButton;

    public void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag == "Player")
        {
            if(gameObject.tag == "CleaningTaskObject")
            {
                Debug.Log("Task");
                cleanButton.SetActive(true);
            }
            else
            {
                searchButton.SetActive(true);
                for (int i = 0; i < mat.materials.Length; i++)
                {
                    mat.material = highlightMat;
                }
            }
           
        }
    }


    public void OnCollisionExit(Collision collision)
    {
        if (gameObject.tag == "CleaningTaskObject")
        {
            Debug.Log("Task");
            cleanButton.SetActive(false);
        }
        else
        {
            searchButton.SetActive(false);

            for (int i = 0; i < mat.materials.Length; i++)
            {
                mat.material = defaultMat;

            }
        }    
           


    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        defaultMat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        
    }
}
