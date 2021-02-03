using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InteractableItem : MonoBehaviour
{
    public float pickUpTime;
    public bool isHoldingButton;
    public bool canInteract;

    IEnumerator HoldSeconds()
    {
        if(isHoldingButton)
        {
            yield return new WaitForSeconds(pickUpTime);
            Debug.Log("Item picked up");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Items")
        {
            Debug.Log("Interactable");
            canInteract = true;
           
        }
    }

    private void Update()
    {
        if (Input.GetKey(0) && canInteract)
        {
            Debug.Log("Holding button");
            isHoldingButton = true;
            StartCoroutine(HoldSeconds());
        }
    }

}
