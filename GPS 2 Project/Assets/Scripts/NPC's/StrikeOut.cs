using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StrikeOut : MonoBehaviour
{
    public int currSus;
    public int maxSus = 3;
    public int currStrike;
    public int maxStrike = 3;
    public bool sus = false;
    public Text susText;
    public Text strikeText;
    public GameObject loseScreenUI;

    public GameObject sus1;
    public GameObject sus2;
    public GameObject sus3;

    public bool GetCaught;

    void Start()
    {
        currSus = 0;
        currStrike = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if ((NpcMovement.isEnemyEnteredBR && RoomTrigger.isPlayerEnteredBR) || (NpcMovement.isEnemyEnteredBRT && RoomTrigger.isPlayerEnteredBRT)
                   || (NpcMovement.isEnemyEnteredTR && RoomTrigger.isPlayerEnteredTR) || (NpcMovement.isEnemyEnteredSR && RoomTrigger.isPlayerEnteredSR)
                   || (NpcMovement.isEnemyEnteredS && RoomTrigger.isPlayerEnteredS) || (NpcMovement.isEnemyEnteredLR && RoomTrigger.isPlayerEnteredLR))
        {
            
            if (sus)
            {
                //npc only increases sus when player is in the same room
                Debug.Log("check sus2222 " + sus);
                //currSus += 1;
                //sus = false;
            }

        }
        

        if(currSus >= maxSus)
        {
            //SceneManager.LoadScene("LoseScreen");
            loseScreenUI.SetActive(true);
            GetCaught = true;

            Time.timeScale = 0f;
        }


        if(currSus == 1)
        {
            sus1.SetActive(true);
        }
        if (currSus == 2)
        {
            sus2.SetActive(true);
        }
        if (currSus == 3)
        {
            sus3.SetActive(true);
        }


        //susText.GetComponent<Text>().text = "Suspicion level: " + currSus.ToString() + "/" + maxSus.ToString();
        //strikeText.GetComponent<Text>().text = "Strike Out: " + currStrike.ToString() + "/" + maxStrike.ToString();

    }
}
