using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t_CleaningList1 : MonoBehaviour
{
    public GameObject[] cleaningList;
    public GameObject player;
    public int num;

    public void onClick()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "shower1.2")
        {
            cleaningList[0].SetActive(true);
            num = 1;
        }
        if (other.name == "Kitchen Counter")
        {
            cleaningList[1].SetActive(true);
            num = 2;
        }
        if (other.name == "shower1.2_bathroom")
        {
            cleaningList[2].SetActive(true);
            num = 3;
        }
        if (other.name == "Dining_Table")
        {
            cleaningList[3].SetActive(true);
            num = 4;
        }
    }



    void Start()
    {
        
    }


    void Update()
    {
        //if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        //    RaycastHit hit;

        //    if (Physics.Raycast(ray, out hit))
        //    {
                
        //        if (hit.collider.name == "shower1.2")
        //        {
        //            cleaningList[0].SetActive(true);
        //            num = 1;
        //        }
        //        if (hit.collider.name == "Kitchen Counter")
        //        {
        //            cleaningList[1].SetActive(true);
        //            num = 2;
        //        }
        //        if (hit.collider.name == "shower1.2_bathroom")
        //        {
        //            cleaningList[2].SetActive(true);
        //            num = 3;
        //        }
        //        if (hit.collider.name == "Dining_Table")
        //        {
        //            cleaningList[3].SetActive(true);
        //            num = 4;
        //        }
        //    }
        //}

    }
}
