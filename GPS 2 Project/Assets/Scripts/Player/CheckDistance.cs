using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDistance : MonoBehaviour
{
    public Transform player;
    public static bool nearPlayer;

    void Awake()
    {
        nearPlayer = this;
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {
       
        if (Vector3.Distance(player.position, gameObject.transform.position) < 2f &&
            GameObject.Find("SelectedManager").GetComponent<InteractableItem>().item != null)
        {
            nearPlayer = true;
        }
        if (Vector3.Distance(player.position, gameObject.transform.position) > 2f)
        {
            nearPlayer = false;

        }
    }
}
