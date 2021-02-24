using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class n_ItemInteract : MonoBehaviour
{
    public string myName;

    public GameObject searchableObjectWindow;
    public GameObject player;

    public n_PorgressBar progressBar;
    public float myProgressTime;
    public float myCurrentTime;

    private int speed = 1;

    void Start()
    {
        myCurrentTime = myProgressTime;
        progressBar.SetProgressTime(myCurrentTime, myProgressTime);

    }

    public void InProgress(float time)
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 120f)
        {
            myCurrentTime -= speed * Time.deltaTime;

            progressBar.SetProgressTime(myCurrentTime, myProgressTime);

            if (myCurrentTime <= myProgressTime)
            {
                searchableObjectWindow.SetActive(true);
                myCurrentTime = 0;
            }
        }
    }

    public void OnPointerDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.name == gameObject.name)
            {
                Debug.Log(hit.collider.gameObject.name);
                if (Vector3.Distance(player.transform.position, transform.position) < 120f)
                {
                    InProgress(myProgressTime);
                }
            }

            
        }
        
    }

    private void Update()
    {
        OnPointerDown();

    }
}
