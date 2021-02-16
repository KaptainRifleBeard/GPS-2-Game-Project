using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDistance : MonoBehaviour
{
    public Transform player;

    //To highlight object
    public Material highlightMat;
    public Material defaultMat;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        defaultMat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        if (Vector3.Distance(player.position, gameObject.transform.position) < 2f)
        {
            gameObject.GetComponent<Renderer>().material = highlightMat;
        }
        if (Vector3.Distance(player.position, gameObject.transform.position) > 2f)
        {
            gameObject.GetComponent<Renderer>().material = defaultMat;

        }
    }
}
