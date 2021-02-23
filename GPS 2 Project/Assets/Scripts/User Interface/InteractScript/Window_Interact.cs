using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window_Interact : MonoBehaviour
{
    public Transform player;
    public Transform item;


    public GameObject cleanningUI;

    void Start()
    {

    }

    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "Medium Window")
                {
                    item = GameObject.Find("Medium Window").transform;

                }


            }


            if (Vector3.Distance(player.position, item.position) < 150f)
            {
                cleanningUI.SetActive(true);
            }
            else
            {
                cleanningUI.SetActive(false);

                item = GameObject.Find("Default (to avoid error msg)").transform;
            }
        }

    }
}
