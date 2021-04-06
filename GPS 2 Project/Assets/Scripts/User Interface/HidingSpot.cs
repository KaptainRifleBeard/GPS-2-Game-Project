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




    public bool clicked;
    static public bool tutorialcheck = false;

    public void onClick()
    {
        clicked = true;
    }



    //public void InProgress(float time)
    //{
    //    myCurrentTime -= speed * Time.deltaTime;
    //    progressBar.SetProgressTime(myCurrentTime, myProgressTime);

    //    if (myCurrentTime <= 0)
    //    {
    //        start = false;
    //        holdButton.holdButton = false;

    //        searchableObjectWindow.SetActive(true);
    //        hideWindow.SetActive(true);
    //        button.SetActive(false);
    //    }
    //}

    void Start()
    {
        //myCurrentTime = myProgressTime;
        //progressBar.SetProgressTime(myCurrentTime, myProgressTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (tutorialcheck == false)
            {
                Tutorial.tutorialTrigg1 = true;
                tutorialcheck = true;
            }
        }
    }

    void Update()
    {
        if (clicked)
        {
            searchableObjectWindow.SetActive(true);
            hideWindow.SetActive(true);
            itemList.moveToHide = true;
        }

        //if (Vector3.Distance(transform.position, player.transform.position) < 200 && holdButton.holdButton == true && start == false &&
        //    Tutorial.tutorialTrigg2 == false && Tutorial.tutorialTrigg1 == false && Tutorial.tutorialTrigg == false)
        //{
        //    searchableObjectWindow.SetActive(true);
        //    hideWindow.SetActive(true);

        //}

        //if (holdButton.holdButton == false)
        //{
        //    start = false;
        //    slider.SetActive(false);
        //}


        //if (start == true)
        //{
        //    itemList.moveToHide = true;
        //    InProgress(myProgressTime);
        //}


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


