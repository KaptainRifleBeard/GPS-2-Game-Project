using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newCheckDistance : MonoBehaviour
{
    public Transform player;

    //To highlight object
    public Renderer mat;

    public Color highlightColor;
    public List<Color> defaultColor;


    public GameObject searchButton;
    public GameObject cleanButton;
    public bool tutorialcheck = false;
    public bool tutorialcheck1 = false;

    public void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag == "Player")
        {
            if (gameObject.tag == "CleaningTaskObject")
            {
                if (tutorialcheck1 == false)
                {
                    Tutorial.tutorialTrigg2 = true;
                    tutorialcheck1 = true;
                }
                Debug.Log("Task");
                cleanButton.SetActive(true);

            }
            else
            {
                searchButton.SetActive(true);
                
                if(tutorialcheck == false)
                {
                    Tutorial.tutorialTrigg = true;
                    tutorialcheck = true;
                }

                for (int i = 0; i < mat.materials.Length; i++)
                {
                    mat.materials[i].color = highlightColor;
                }
               
                
            }

        }
    }


    public void OnCollisionExit(Collision collision)
    {
        searchButton.SetActive(false);
        cleanButton.SetActive(false);
        for (int i = 0; i < mat.materials.Length; i++)
        {
            mat.materials[i].color = defaultColor[i];
        }
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i = 0; i < mat.materials.Length; i++)
        {
            defaultColor.Add(mat.materials[i].color);
        }

    }

    void Update()
    {
        //if(gameObject.tag == "CleaningTaskObject")
        //{
        //    mat.material.color = Color.green;

        //}
    }
}
