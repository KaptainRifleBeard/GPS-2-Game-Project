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
    public GameObject npc;

    public n_PorgressBar progressBar;
    public UI_Button stop;
    public t_itemList startSpawn;
    public n_searchButtonHold holdButton;
    public StrikeOut strike;

    public float myProgressTime;
    public float myCurrentTime;

    private int speed = 1;
    public bool start;
    public bool jewlFound;
    public bool activeWindow;

    public float suspicionCoolDown = 2f;
    bool ableDetect = true;
    int i = 0;

    private IEnumerator coolDown(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        ableDetect = true;
        i = 0;
    }

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
            if (gameObject.name == "King sized bed")
            {
                myCurrentTime = myProgressTime;

                jewlFound = true;
                start = true;

            }
            else
            {
                myCurrentTime = myProgressTime;
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
        }
        else
        {
            strike.sus = false;
            myCurrentTime = myProgressTime;
            
        }



        if (stop.exitWindow == true)
        {
            start = false;
            startSpawn.start = false;
            activeWindow = false;
            strike.sus = false;

            slider.SetActive(false);

        }

        if((Vector3.Distance(transform.position, npc.transform.position) < 400 && start == true) || 
            (Vector3.Distance(transform.position, npc.transform.position) < 400 && activeWindow == true))
        {
            if (i < 1)
            {
                FindObjectOfType<_AudioManager>().Play("StrikeOut");

                strike.currSus += 1;

                if (ableDetect == true)
                {
                    strike.sus = true;
                    i++;
                }
            }
            if (strike.sus == true)
            {
                ableDetect = false;
                StartCoroutine(coolDown(suspicionCoolDown));
            }
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
