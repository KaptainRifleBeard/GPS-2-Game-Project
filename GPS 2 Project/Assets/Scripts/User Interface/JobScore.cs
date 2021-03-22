using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JobScore : MonoBehaviour
{
    public Text score;
    public Text highest;

    public int highestScore;
    public static int currScore = 0;

    public StrikeOut strikeout;

    void Start()
    {

    }


    void Update()
    {
        score.text = currScore.ToString();
        highest.text = PlayerPrefs.GetInt("HighestScore").ToString();

        if (PlayerPrefs.GetInt("HighestScore") < currScore)
        {
            PlayerPrefs.SetInt("HighestScore", currScore);
        }
        //score.text = currScore.ToString();
        //if (currScore > PlayerPrefs.GetInt("HighestScore", 0))
        //{
        //    PlayerPrefs.SetInt("HighestScore", currScore);
        //    highest.text = highestScore.ToString();
        //}

    }


    public void LeaveGame()
    {
        //PlayerPrefs.SetInt("HighestScore", 0);
        //highestScore -= currScore;
        //currScore = 0;


    }

    public void resetScore()
    {
        currScore = 0;

        //if (PlayerPrefs.GetInt("HighestScore") < currScore)
        //{
        //    PlayerPrefs.SetInt("HighestScore", currScore);
        //}
    }

}
