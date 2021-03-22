using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HidingSpot : MonoBehaviour
{
    public GameObject searchableObjectWindow;
    public GameObject hideWindow;
    public GameObject slider;
    public GameObject player;
    public GameObject button;

    public n_PorgressBar progressBar;
    public n_searchButtonHold holdButton;
    public t_itemList itemList;

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
            start = false;
            holdButton.holdButton = false;

            searchableObjectWindow.SetActive(true);
            hideWindow.SetActive(true);
            button.SetActive(false);
        }
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 200 && holdButton.holdButton == true && start == false)
        {
            myCurrentTime = myProgressTime;
            start = true;

        }

        if (holdButton.holdButton == false)
        {
            start = false;
            slider.SetActive(false);
        }


        if (start == true)
        {
            itemList.moveToHide = true;
            InProgress(myProgressTime);
        }


    }
}



    //public GameObject HidingSpotWindow;
    //public GameObject hidingSpot;

    //public Transform player;
    //public bool hidingOpen = false;

    //public t_itemList itemList;

    //void Start()
    //{
        
    //}


    //void Update()
    //{
    //    if(!hidingOpen)
    //    {
    //        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
    //        {
    //            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
    //            RaycastHit hit;

    //            if (Physics.Raycast(ray, out hit))
    //            {
    //                if (Vector3.Distance(player.position, transform.position) < 120f && hit.collider != null)
    //                {
    //                    Debug.Log(hit.collider);

    //                    HidingSpotWindow.SetActive(true);
    //                    hidingSpot.SetActive(true);
    //                    hidingOpen = true;

    //                    itemList.moveToHide = true;

    //                }
    //            }
    //        }
    //    }
       

    //}


