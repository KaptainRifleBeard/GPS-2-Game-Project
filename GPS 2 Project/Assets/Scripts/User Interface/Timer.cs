using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float startTime = 360f;
    public Text textBox;
    public GameObject loseScreen;

    void Start()
    {
        textBox.text = startTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        startTime -= Time.deltaTime;

        int min = Mathf.FloorToInt(startTime / 60);
        int sec = Mathf.FloorToInt(startTime % 60);
        textBox.GetComponent<Text>().text = min.ToString("00") + ":" + sec.ToString("00");

        if(startTime < 0)
        {
            loseScreen.SetActive(true);
        }

    }
}
