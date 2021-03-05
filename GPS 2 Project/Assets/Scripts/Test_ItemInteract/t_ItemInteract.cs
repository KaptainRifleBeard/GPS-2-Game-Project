using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t_ItemInteract : MonoBehaviour
{
    public GameObject slider;

    public GameObject player;

    public n_PorgressBar progressBar;
    public float myProgressTime;
    public float myCurrentTime;

    private int speed = 1;
    bool start;

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
        }

    }

    private void Update()
    {
        if (start == false)
        {
            myCurrentTime = myProgressTime;

            if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider != null)
                    {
                        start = true;

                    }
                    else
                    {
                        start = false;
                    }
                }
            }
        }


        if (start && Vector3.Distance(player.transform.position, transform.position) < 120f)
        {
            InProgress(myProgressTime);
        }
        else
        {
            slider.SetActive(false);
            start = false;
        }

    }
}
