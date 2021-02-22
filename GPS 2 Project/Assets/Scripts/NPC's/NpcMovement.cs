using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class NpcMovement : MonoBehaviour
{

    public Transform[] points;
    public Transform target;
    public float idleTime;
    static public bool isIdle = false;
    static public bool sus = false;

    private NavMeshAgent agent;
    public float waitDuration = 5f;
    public float talkDuration = 10f;
    public float waitTimer;
    public float talkTimer;
    static public bool isEnemyEntered = false;
    public bool hasTalked = false;
    public int destPoint = 0;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = false;
        destPoint = Random.Range(0, points.Length);
        agent.SetDestination(points[destPoint].position);


    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Room"))
        {
            isEnemyEntered = true;
            Debug.Log("Enemy Entered");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Room"))
        {
            isEnemyEntered = false;
            Debug.Log("Enemy left");
        }
    }

    void Update()
    {
        int layerMask = 1 << 3;

        

        if(isEnemyEntered && RoomTrigger.isPlayerEntered)
        {
            if(isIdle)
            {
                if (!hasTalked)
                {
                    agent.SetDestination(target.position);
                    agent.stoppingDistance = 1.5f;
                }
                else
                {
                    if (Vector3.Distance(transform.position, points[destPoint].position) < 0.6f)
                    {
                        waitTimer += Time.deltaTime;
                        if (waitTimer > waitDuration)
                        {
                            waitTimer = 0;
                            destPoint = Random.Range(0, points.Length);
                            agent.SetDestination(points[destPoint].position);
                        }

                    }
                }
            }
            
            if(StrikeOut.sus)
            {
                sus = true;
            }
            else
            {
                sus = false;
            }

        }
        else
        {
            agent.SetDestination(points[destPoint].position);
            if (Vector3.Distance(transform.position, points[destPoint].position) < 0.6f)
            {
                waitTimer += Time.deltaTime;
                if (waitTimer > waitDuration)
                {
                    waitTimer = 0;
                    destPoint = Random.Range(0, points.Length);
                    agent.SetDestination(points[destPoint].position);
                }

            }
        }
        

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2, layerMask) || Physics.Raycast(transform.position, transform.TransformDirection(0.5f, 0, 1), out hit, 5, layerMask) || Physics.Raycast(transform.position, transform.TransformDirection(-0.5f, 0, 1), out hit, 5, layerMask))
        {
             
            Debug.Log("Did Hit");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 2, Color.red);
            Debug.DrawRay(transform.position, transform.TransformDirection(0.5f, 0, 1) * 2, Color.red);
            Debug.DrawRay(transform.position, transform.TransformDirection(-0.5f, 0, 1) * 2, Color.red);
            if (isIdle)
            {
                if(!hasTalked)
                {
                    talkTimer += Time.deltaTime;
                    if (talkTimer > talkDuration)
                    {
                        talkTimer = 0;
                        hasTalked = true;
                        agent.SetDestination(points[destPoint].position);
                    }

                }

            }
            
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 2, Color.yellow);
            Debug.DrawRay(transform.position, transform.TransformDirection(0.5f, 0, 1) * 2, Color.yellow);
            Debug.DrawRay(transform.position, transform.TransformDirection(-0.5f, 0, 1) * 2, Color.yellow);
            //Debug.Log("Did not Hit");
            if (!hasTalked)
            {
                 talkTimer = 0;
                 agent.SetDestination(points[destPoint].position);
            }
        }

        

    }

}