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

    public static int num = 0;
    bool start;
    int minN;
    int secN;

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
            newStartTime += Time.deltaTime * 10f;
           

            minN = Mathf.FloorToInt(newStartTime / 60);
            secN = Mathf.FloorToInt(newStartTime % 60);
            textBox.GetComponent<Text>().text = minN.ToString("00") + ":" + secN.ToString("00") + " pm";

            
        }

        if(num < 1)
        {
            if (minN >= 2 && secN >= 56)
            {
                Debug.Log("Start ringing");
                FindObjectOfType<_AudioManager>().Play("Clock");
                num++;
            }
        }
        


        if (newStartTime > 180f && levelManager.completedAllTask == false) //3pm
        {
            loseScreen.SetActive(true);
        }
        if(newStartTime > 180f && levelManager.completedAllTask == true)
        {
            winScreen.SetActive(true);
        }

    }

}
