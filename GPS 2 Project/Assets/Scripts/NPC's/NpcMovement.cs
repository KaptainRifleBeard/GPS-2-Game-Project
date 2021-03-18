using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using UnityEngine.UI;


public class NpcMovement : MonoBehaviour
{

    public Transform[] points;
    public Transform target;
    public Text dialogueText;
    static public bool isIdle = false;
    public bool allowTalk = false;

    string[] dialogue = {"Oh I'm just checking.", "How’s it going?" , "Just taking a small break."};
    int dialogueArr;
    public Transform textDisplay;
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

        dialogueText.gameObject.SetActive(false);
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
        int layerMask = 3;

        Vector3 textDisplay = Camera.main.WorldToScreenPoint(this.textDisplay.position);
        dialogueText.transform.position = textDisplay;

        if ((isEnemyEnteredBR && RoomTrigger.isPlayerEnteredBR) || (isEnemyEnteredBRT && RoomTrigger.isPlayerEnteredBRT) || (isEnemyEnteredTR && RoomTrigger.isPlayerEnteredTR) || (isEnemyEnteredSR && RoomTrigger.isPlayerEnteredSR)
            || (isEnemyEnteredS && RoomTrigger.isPlayerEnteredS) || (isEnemyEnteredLR && RoomTrigger.isPlayerEnteredLR))
        {
            Debug.Log("Same room together");
            //if (isIdle)
            //{
                if (!hasTalked)
                {
                    agent.SetDestination(target.position);
                    agent.stoppingDistance = 100f;
                    allowTalk = true;
                dialogueArr = Random.Range(0, dialogue.Length);
                

            }
            //}


        }


        if (Vector3.Distance(transform.position, points[destPoint].position) < 150f)
        {

            destPoint = Random.Range(0, points.Length);
            //agent.Stop();
            StartCoroutine(waiting(waitDuration));
        }



        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(0f, 100, 1), out hit, 50, layerMask) || Physics.Raycast(transform.position, transform.TransformDirection(0.5f, 100, 1), out hit, 50, layerMask) || Physics.Raycast(transform.position, transform.TransformDirection(-0.5f, 100, 1), out hit, 50, layerMask))
        {

            if (allowTalk)
            {
                dialogueText.GetComponent<Text>().text = dialogue[dialogueArr];
                dialogueText.gameObject.SetActive(true);
                StartCoroutine(talking(talkDuration));
            }
            else
            {
                dialogueText.gameObject.SetActive(false);
            }
            Debug.Log("Did Hit");
            Debug.DrawRay(transform.position, transform.TransformDirection(0f, 0, 1) * 50, Color.red);
            Debug.DrawRay(transform.position, transform.TransformDirection(0.5f, 0, 1) * 50, Color.red);
            Debug.DrawRay(transform.position, transform.TransformDirection(-0.5f, 0, 1) * 50, Color.red);
            //if (isIdle)
            //{
            //    if(!hasTalked)
            //    {
            //        talkTimer += Time.deltaTime;
            //        if (talkTimer > talkDuration)
            //        {
            //            talkTimer = 0;
            //            hasTalked = true;
            //            agent.SetDestination(points[destPoint].position);
            //        }

            //    }

            //}

            

        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(0f, 0, 1) * 50, Color.yellow);
            Debug.DrawRay(transform.position, transform.TransformDirection(0.5f, 0, 1) * 50, Color.yellow);
            Debug.DrawRay(transform.position, transform.TransformDirection(-0.5f, 0, 1) * 50, Color.yellow);
            //Debug.Log("Did not Hit");
            //if (!hasTalked)
            //{
            //     talkTimer = 0;
            //     agent.SetDestination(points[destPoint].position);
            //}
            dialogueText.gameObject.SetActive(false);
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
        hasTalked = true;
    }

}