using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProrgessBar : MonoBehaviour
{
    public Transform text;
    public Transform progressBar;

    [SerializeField] private float currentTime;
    [SerializeField] private float speed;
    public float time;

    void Update()
    {
        if (currentTime < GameObject.Find("SelectedManager").GetComponent<InteractableItem>().prorgessTime)
        {
            currentTime += speed * Time.deltaTime;
            text.GetComponent<Text>().text = ((int)currentTime).ToString();
        }
        progressBar.GetComponent<Image>().fillAmount = currentTime / GameObject.Find("SelectedManager").GetComponent<InteractableItem>().prorgessTime;
    }
}
