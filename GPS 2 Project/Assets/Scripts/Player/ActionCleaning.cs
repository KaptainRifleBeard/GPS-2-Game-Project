using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionCleaning : MonoBehaviour
{
    public Transform player;
    public Transform item;


    public GameObject cleanningUI;
    public GameObject tableclen;
    public GameObject carpetclean;

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
                //set item wait time
                if (hit.collider.name == "Living_Room_Carpet")
                {
                    item = GameObject.Find("Living_Room_Carpet").transform;
                    if (Vector3.Distance(player.position, item.position) < 150f)
                    {
                        carpetclean.SetActive(true);
                    }
                }
                if (hit.collider.name == "Medium Window")
                {
                    item = GameObject.Find("Medium Window").transform;
                    if (Vector3.Distance(player.position, item.position) < 150f)
                    {
                        cleanningUI.SetActive(true);
                    }
                }
                if (hit.collider.name == "Dining_Table")
                {
                    item = GameObject.Find("Dining_Table").transform;
                    if (Vector3.Distance(player.position, item.position) < 150f)
                    {
                        tableclen.SetActive(true);
                    }
                }
               

            }

            if (Vector3.Distance(player.position, item.position) > 150f)
            {
                tableclen.SetActive(false);
                cleanningUI.SetActive(false);
                carpetclean.SetActive(false);

                item = GameObject.Find("Default (to avoid error msg)").transform;
            }
        }


    }
}
