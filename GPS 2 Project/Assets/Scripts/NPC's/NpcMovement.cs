using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class NpcMovement : MonoBehaviour
{

    public Transform[] points;
    public float idleTime;
    static public bool sus = false;
    private int destPoint = 0;
    private NavMeshAgent agent;

    enum EnemyStates
    {
        Patrolling,
        Chasing
    }

    [SerializeField] EnemyStates currentState;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = false;
        currentState = EnemyStates.Patrolling;
        agent.SetDestination(points[Random.Range(0, points.Length)].position);
        if (currentState == EnemyStates.Patrolling)
        {
            InvokeRepeating("GotoNextPoint", 1f, idleTime);
        }
        

    }


    void GotoNextPoint()
    {

        if (Vector3.Distance(transform.position, points[destPoint].position) < 0.6f)
        {
            //destPoint++;
            //if (destPoint == points.Length)
            //{
            //    destPoint = 0;
            //}
            destPoint = Random.Range(0, points.Length);
        }
        agent.SetDestination(points[destPoint].position);
    }


    void Update()
    {
        int layerMask = 1 << 3;
       
        

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 3, layerMask) || Physics.Raycast(transform.position, transform.TransformDirection(0.5f, 0, 1), out hit, 5, layerMask) || Physics.Raycast(transform.position, transform.TransformDirection(-0.5f, 0, 1), out hit, 5, layerMask))
        {
            
            if (sus == true)
            {
                agent.SetDestination(hit.point);
            }
            
            Debug.Log("Did Hit");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 3, Color.red);
            Debug.DrawRay(transform.position, transform.TransformDirection(0.5f, 0, 1) * 3, Color.red);
            Debug.DrawRay(transform.position, transform.TransformDirection(-0.5f, 0, 1) * 3, Color.red);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 3, Color.yellow);
            Debug.DrawRay(transform.position, transform.TransformDirection(0.5f, 0, 1) * 3, Color.yellow);
            Debug.DrawRay(transform.position, transform.TransformDirection(-0.5f, 0, 1) * 3, Color.yellow);
            //Debug.Log("Did not Hit");
        }

        

    }

    //IEnumerator Patrol()
    //{
    //    yield return new WaitForSeconds(idleTime);
    //    GotoNextPoint();
    //}
}