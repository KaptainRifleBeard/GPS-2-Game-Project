using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HidingSpot : MonoBehaviour
{
    public GameObject HidingSpotWindow;
    public GameObject hidingSpot;

    public Transform player;
    public bool hidingOpen = false;

    public t_itemList itemList;

    void Start()
    {
        
    }


    void Update()
    {
        if(!hidingOpen)
        {
            if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (Vector3.Distance(player.position, transform.position) < 120f && hit.collider != null)
                    {
                        Debug.Log(hit.collider);

                        HidingSpotWindow.SetActive(true);
                        hidingSpot.SetActive(true);
                        hidingOpen = true;

                        itemList.moveToHide = true;

                    }
                }
            }
        }
       

    }

}
