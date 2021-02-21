using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingSpot : MonoBehaviour
{
    public GameObject HidingSpotWindow;
    public Transform player;

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


                }
                else
                {
                    HidingSpotWindow.SetActive(false);


                }
            }
        }

        
    }

    public void HidingSpotWindow_ExitButton()
    {
        Debug.Log("tap");
        HidingSpotWindow.SetActive(false);

    }
}
