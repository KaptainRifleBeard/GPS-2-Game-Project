using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HidingSpot : MonoBehaviour
{
    public GameObject HidingSpotWindow;
    public GameObject hidingSpot;

    public Transform player;
    public bool hidingOpen = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (Vector3.Distance(player.position, gameObject.transform.position) < 2f && hit.collider.name == "Hiding Spot")
                {
                    Debug.Log("show");

                    HidingSpotWindow.SetActive(true);
                    hidingSpot.SetActive(true);
                    hidingOpen = true;

                }
            }
        }

        
    }

    public void HidingSpotWindow_ExitButton()
    {
        Debug.Log("tap");
        HidingSpotWindow.SetActive(false);
        hidingSpot.SetActive(false);


    }
}
