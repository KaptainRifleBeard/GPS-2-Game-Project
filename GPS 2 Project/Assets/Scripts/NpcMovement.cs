using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] Waypoints;
    public Transform spawnPoint;
    public Transform triggerPoint;
    public Transform visionCone;
    public float moveSpeed = 3f;
    public float delayTimer = 2f;
    public int CurrentPoint = 0;
    bool moved = false;
    public int waypointTable;
    // -1 and 0 are to do nothing, rest are dedicated towards waypoints.
    float delay;

    void Start()
    {
        transform.position = spawnPoint.position;
        triggerPoint.position = transform.position;
        visionCone.position = transform.position;
        Time.timeScale = 1f;


    }
    void Update()
    {
        if (moved == false)
        {
            // if no current movement behaviour, initiate randomizer.
            Random.Range(-1, Waypoints.Length);



            // checking if rand
        }


        if (transform.position == Waypoints[CurrentPoint].transform.position)
        {
            
            CurrentPoint += 1;
        }

        else if (transform.position != Waypoints[CurrentPoint].transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, Waypoints[CurrentPoint].transform.position, moveSpeed* Time.timeScale);
            triggerPoint.position = Vector3.MoveTowards(triggerPoint.position, Waypoints[CurrentPoint].transform.position, moveSpeed * Time.timeScale);
            visionCone.position = Vector3.MoveTowards(triggerPoint.position, Waypoints[CurrentPoint].transform.position, moveSpeed* Time.timeScale);
        }

        if (CurrentPoint >= Waypoints.Length)
        {
            CurrentPoint = 0;
        }
    }
    // incomplete, requires further work.

}
