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
    public GameObject button;

    public n_PorgressBar progressBar;
    public UI_Button stop;
    public t_itemList startSpawn;
    public n_searchButtonHold holdButton;

    public float myProgressTime;
    public float myCurrentTime;

    private int speed = 1;
    public bool start;
    public bool jewlFound;
    public bool activeWindow;


    public void InProgress(float time)
    {
        myCurrentTime -= speed * Time.deltaTime;
        progressBar.SetProgressTime(myCurrentTime, myProgressTime);

        if (myCurrentTime <= 0)
        {
            start = false;
            holdButton.holdButton = false;

            activeWindow = true;
            searchableObjectWindow.SetActive(true);
            safeWindow.SetActive(true);
            button.SetActive(false);
        }

    }



    void Start()
    {
        myCurrentTime = myProgressTime;
        progressBar.SetProgressTime(myCurrentTime, myProgressTime);

    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 200 && holdButton.holdButton == true && start == false)
        {
            myCurrentTime = myProgressTime;


            if (gameObject.name == "King sized bed")
            {
                jewlFound = true;
                start = true;

            }
            else
            {
                jewlFound = false;

                start = true;
                startSpawn.start = true;

            }


        }

        if (holdButton.holdButton == false)
        {
            start = false;
            slider.SetActive(false);
        }


        if (start == true)
        {
            InProgress(myProgressTime);
            StrikeOut.sus = true;

        }
        else
        {
            StrikeOut.sus = false;

        }


        if (stop.exitWindow == true)
        {
            start = false;
            startSpawn.start = false;
            activeWindow = false;

            slider.SetActive(false);

        }
        


    }


}
//if(start == false)
//{
//    myCurrentTime = myProgressTime;

//    if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
//    {
//        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
//        RaycastHit hit;

//        if (Physics.Raycast(ray, out hit))
//        {
//            if (hit.collider != null && Vector3.Distance(player.transform.position, transform.position) < 120f)
//            {

//                if (hit.collider.name == "Master Bed")
//                {
//                    jewlFound = true;
//                }
//                else
//                {
//                    start = true;
//                    startSpawn.start = true;

//                }
//            }
//        }
//    }
//}
