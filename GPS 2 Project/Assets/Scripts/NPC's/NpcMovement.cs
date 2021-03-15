using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class NpcMovement : MonoBehaviour
{

    public Transform[] points;
    public Transform target;
    static public bool isIdle = false;

    private NavMeshAgent agent;
    public float waitDuration = 5f;
    public float talkDuration = 10f;
    public float waitTimer;
    public float talkTimer;
    static public bool isEnemyEnteredBR = false;
    static public bool isEnemyEnteredBRT = false;
    static public bool isEnemyEnteredTR = false;
    static public bool isEnemyEnteredSR = false;
    static public bool isEnemyEnteredS = false;
    static public bool isEnemyEnteredLR = false;
    public bool hasTalked = false;
    public int destPoint = 0;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = true;
        destPoint = Random.Range(0, points.Length);
        agent.SetDestination(points[destPoint].position);


    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bedroom"))
        {
            isEnemyEnteredBR = true;
            Debug.Log("Enemy Entered Bedroom");
        }

        if (other.gameObject.CompareTag("BedroomToilet"))
        {
            isEnemyEnteredBRT = true;
            Debug.Log("Enemy Entered BedroomToilet");
        }

        if (other.gameObject.CompareTag("TeenRoom"))
        {
            isEnemyEnteredTR = true;
            Debug.Log("Enemy Entered TeenRoom");
        }

        if (other.gameObject.CompareTag("ShowerRoom"))
        {
            isEnemyEnteredSR = true;
            Debug.Log("Enemy Entered ShowerRoom");
        }

        if (other.gameObject.CompareTag("Store"))
        {
            isEnemyEnteredS = true;
            Debug.Log("Enemy Entered Store");
        }

        if (other.gameObject.CompareTag("LivingRoom"))
        {
            isEnemyEnteredLR = true;
            Debug.Log("Enemy Entered LivingRoom");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Bedroom"))
        {
            isEnemyEnteredBR = false;
            Debug.Log("Enemy left Bedroom");
        }

        if (other.gameObject.CompareTag("BedroomToilet"))
        {
            isEnemyEnteredBRT = false;
            Debug.Log("Enemy left BedroomToilet");
        }

        if (other.gameObject.CompareTag("TeenRoom"))
        {
            isEnemyEnteredTR = false;
            Debug.Log("Enemy left TeenRoom");
        }

        if (other.gameObject.CompareTag("ShowerRoom"))
        {
            isEnemyEnteredSR = false;
            Debug.Log("Enemy left ShowerRoom");
        }

        if (other.gameObject.CompareTag("Store"))
        {
            isEnemyEnteredS = false;
            Debug.Log("Enemy left Store");
        }

        if (other.gameObject.CompareTag("LivingRoom"))
        {
            isEnemyEnteredLR = false;
            Debug.Log("Enemy left LivingRoom");
        }
    }

    

    void Update()
    {
        int layerMask = 1 << 3;



        if ((isEnemyEnteredBR && RoomTrigger.isPlayerEnteredBR) || (isEnemyEnteredBRT && RoomTrigger.isPlayerEnteredBRT) || (isEnemyEnteredTR && RoomTrigger.isPlayerEnteredTR) || (isEnemyEnteredSR && RoomTrigger.isPlayerEnteredSR)
            || (isEnemyEnteredS && RoomTrigger.isPlayerEnteredS) || (isEnemyEnteredLR && RoomTrigger.isPlayerEnteredLR))
        {
            if (isIdle)
            {
                if (!hasTalked)
                {
                    agent.SetDestination(target.position);
                    agent.stoppingDistance = 1.5f;
                    StartCoroutine(talking(talkDuration));
                }
            }


        }


        if (Vector3.Distance(transform.position, points[destPoint].position) < 150f)
        {

            destPoint = Random.Range(0, points.Length);
            StartCoroutine(waiting(waitDuration));
        }



        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2, layerMask) || Physics.Raycast(transform.position, transform.TransformDirection(0.5f, 0, 1), out hit, 5, layerMask) || Physics.Raycast(transform.position, transform.TransformDirection(-0.5f, 0, 1), out hit, 5, layerMask))
        {
             
            Debug.Log("Did Hit");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.red);
            Debug.DrawRay(transform.position, transform.TransformDirection(0.5f, 0, 1) * 100, Color.red);
            Debug.DrawRay(transform.position, transform.TransformDirection(-0.5f, 0, 1) * 100, Color.red);
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
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.yellow);
            Debug.DrawRay(transform.position, transform.TransformDirection(0.5f, 0, 1) * 100, Color.yellow);
            Debug.DrawRay(transform.position, transform.TransformDirection(-0.5f, 0, 1) * 100, Color.yellow);
            //Debug.Log("Did not Hit");
            if (!hasTalked)
            {
                 talkTimer = 0;
                 agent.SetDestination(points[destPoint].position);
            }
        }

        

    }

    private IEnumerator waiting(float waitTime)
    {

        yield return new WaitForSeconds(waitTime);
        agent.SetDestination(points[destPoint].position);
    }

    private IEnumerator talking(float talkTime)
    {

        yield return new WaitForSeconds(talkTime);
        agent.SetDestination(points[destPoint].position);
    }

}