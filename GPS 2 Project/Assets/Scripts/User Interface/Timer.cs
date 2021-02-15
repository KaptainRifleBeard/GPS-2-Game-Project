using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float startTime = 360f;
    public Text textBox;

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
        textBox.GetComponent<UnityEngine.UI.Text>().text = min.ToString("00") + ":" + sec.ToString("00");

    }
}
