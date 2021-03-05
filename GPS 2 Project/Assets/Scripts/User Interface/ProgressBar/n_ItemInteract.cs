using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class n_ItemInteract : MonoBehaviour
{
    public GameObject searchableObjectWindow;
    public GameObject safeWindow;
    public GameObject slider;
    public GameObject player;

    public n_PorgressBar progressBar;
    public UI_Button stop;

    public float myProgressTime;
    public float myCurrentTime;

    private int speed = 1;
    public bool start;

    void Start()
    {
        myCurrentTime = myProgressTime;
        progressBar.SetProgressTime(myCurrentTime, myProgressTime);

    }

    public void InProgress(float time)
    {
        myCurrentTime -= speed * Time.deltaTime;
        progressBar.SetProgressTime(myCurrentTime, myProgressTime);

        if (myCurrentTime <= 0)
        {
            searchableObjectWindow.SetActive(true);
            safeWindow.SetActive(true);

            start = false;

        }
    }

    private void Update()
    {
        if(start == false)
        {
            myCurrentTime = myProgressTime;

            if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider != null && Vector3.Distance(player.transform.position, transform.position) < 120f)
                    {
                        start = true;
                    }
                }
            }
        }
        

        if(start)
        {
            InProgress(myProgressTime);
        }


        if (start && Vector3.Distance(player.transform.position, transform.position) > 120f)
        {
            slider.SetActive(false);
            start = false;
        }

        if(stop.stop == true)
        {
            slider.SetActive(false);
            start = false;

        }

    }


}
