using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTrigger : MonoBehaviour
{
    static public bool isPlayerEntered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Room"))
        {
            isPlayerEntered = true;
            Debug.Log("Player Entered");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Room"))
        {
            isPlayerEntered = false;
            Debug.Log("Player left");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
