using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class n_PorgressBar : MonoBehaviour
{
    public Camera cam;
    public Slider slider;

    public Vector3 offset;  
    public void SetProgressTime(float currTime, float maxProgressTime)
    {
        slider.gameObject.SetActive(currTime < maxProgressTime);
        slider.value = currTime;
        slider.maxValue = maxProgressTime;
    }

    private void Start()
    {

    }

    void Update()
    {
        //transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + offset);

    }

}
