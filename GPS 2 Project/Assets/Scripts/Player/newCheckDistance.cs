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

    public Material[] hMat;



    public GameObject searchButton;
    public GameObject cleanButton;

    IEnumerator blink()
    {
        for (int n = 0; n < 100; n++)
        {
            mat.material.color = Color.green;
            yield return new WaitForSeconds(3.0f);
            mat.material.color = Color.white;
            yield return new WaitForSeconds(3.0f);
        }
    }


    public void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag == "Player")
        {
            searchButton.SetActive(true);
            if (gameObject.tag == "CleaningTaskObject")
            {

                Debug.Log("Task");
                cleanButton.SetActive(true);

            }


            //highlight
            for (int i = 0; i < mat.materials.Length;)
            {
                mat.material = highlightMat;
                i++;
            }



        }
    }


    public void OnCollisionExit(Collision collision)
    {
        searchButton.SetActive(false);
        cleanButton.SetActive(false);

        for (int i = 0; i < mat.materials.Length; i++)
        {
            mat.material = defaultMat;
        }

        //loop store default color
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        defaultMat = GetComponent<Renderer>().material;

    }

    void Update()
    {
        if(gameObject.tag == "CleaningTaskObject")
        {
            mat.material.color = Color.green;

            //StartCoroutine(blink());
        }
    }
}
