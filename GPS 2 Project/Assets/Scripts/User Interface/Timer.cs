using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float startTime = 660f; //11am
    public Text textBox;
    public GameObject loseScreen;
    public GameObject winScreen;

    bool isPM;
    public static float newStartTime = 60f;
    public LevelManager levelManager;
    void Start()
    {
        textBox.text = startTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(startTime < 780f)
        {
            startTime += Time.deltaTime;

            int min = Mathf.FloorToInt(startTime / 60);
            int sec = Mathf.FloorToInt(startTime % 60);
            textBox.GetComponent<Text>().text = min.ToString("00") + ":" + sec.ToString("00") + " am";
            
            
            if (startTime > 720f)
            {
                textBox.GetComponent<Text>().text = min.ToString("00") + ":" + sec.ToString("00") + " pm";
            }
        }
        else
        {
            isPM = true;

            newStartTime += Time.deltaTime;

            int minN = Mathf.FloorToInt(newStartTime / 60);
            int secN = Mathf.FloorToInt(newStartTime % 60);
            textBox.GetComponent<Text>().text = minN.ToString("00") + ":" + secN.ToString("00") + " pm";
        }

       


        if (isPM == true && newStartTime > 300f) //5pm
        {
            loseScreen.SetActive(true);
        }
        if(newStartTime > 300f && levelManager.completedAllTask == true)
        {
            winScreen.SetActive(true);
        }

    }
}
