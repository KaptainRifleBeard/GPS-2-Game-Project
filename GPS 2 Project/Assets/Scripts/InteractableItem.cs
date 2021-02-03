using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractableItem : MonoBehaviour
{
    public bool canInteract;
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Items")
        {
            Debug.Log("Interactable = true");
            canInteract = true;
           
        }
    }


}
