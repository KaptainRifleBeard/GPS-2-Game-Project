using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTrigger : MonoBehaviour
{
    static public bool isPlayerEnteredBR = false;
    static public bool isPlayerEnteredBRT = false;
    static public bool isPlayerEnteredTR = false;
    static public bool isPlayerEnteredSR = false;
    static public bool isPlayerEnteredS = false;
    static public bool isPlayerEnteredLR = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bedroom"))
        {
            isPlayerEnteredBR = true;
            Debug.Log("Player Entered");
        }

        if (other.gameObject.CompareTag("BedroomToilet"))
        {
            isPlayerEnteredBRT = true;
            Debug.Log("Player Entered BedroomToilet");
        }

        if (other.gameObject.CompareTag("TeenRoom"))
        {
            isPlayerEnteredTR = true;
            Debug.Log("Player Entered TeenRoom");
        }

        if (other.gameObject.CompareTag("ShowerRoom"))
        {
            isPlayerEnteredSR = true;
            Debug.Log("Player Entered ShowerRoom");
        }

        if (other.gameObject.CompareTag("Store"))
        {
            isPlayerEnteredS = true;
            Debug.Log("Player Entered Store");
        }

        if (other.gameObject.CompareTag("LivingRoom"))
        {
            isPlayerEnteredLR = true;
            Debug.Log("Player Entered LivingRoom");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Bedroom"))
        {
            isPlayerEnteredBR = false;
            Debug.Log("Player left Bedroom");
        }

        if (other.gameObject.CompareTag("BedroomToilet"))
        {
            isPlayerEnteredBRT = false;
            Debug.Log("Enemy left BedroomToilet");
        }

        if (other.gameObject.CompareTag("TeenRoom"))
        {
            isPlayerEnteredTR = false;
            Debug.Log("Enemy left TeenRoom");
        }

        if (other.gameObject.CompareTag("ShowerRoom"))
        {
            isPlayerEnteredSR = false;
            Debug.Log("Enemy left ShowerRoom");
        }

        if (other.gameObject.CompareTag("Store"))
        {
            isPlayerEnteredS = false;
            Debug.Log("Enemy left Store");
        }

        if (other.gameObject.CompareTag("LivingRoom"))
        {
            isPlayerEnteredLR = false;
            Debug.Log("Enemy left LivingRoom");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
