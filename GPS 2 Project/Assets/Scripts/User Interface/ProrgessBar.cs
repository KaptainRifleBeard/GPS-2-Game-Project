using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProrgessBar : MonoBehaviour
{
    public Transform text;
    public Transform progressBar;
    public Transform player;

    [SerializeField] private float currentTime;
    [SerializeField] private float speed;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        //CheckDistance.nearPlayer == true
        if (GameObject.Find("SelectedManager").GetComponent<InteractableItem>().clickOnObject == true)
        {
            gameObject.SetActive(true);
            if (currentTime <= GameObject.Find("SelectedManager").GetComponent<InteractableItem>().progressTime)
            {
                currentTime += speed * Time.deltaTime;
                //text.GetComponent<Text>().text = ((int)currentTime).ToString();
                StrikeOut.sus = true;
            }
            progressBar.GetComponent<Image>().fillAmount = currentTime / GameObject.Find("SelectedManager").GetComponent<InteractableItem>().progressTime;
        }


        if (GameObject.Find("SelectedManager").GetComponent<InteractableItem>().clickOnObject == false)
        {
            currentTime = 0;
            //text.GetComponent<Text>().text = ((int)currentTime).ToString();
            progressBar.GetComponent<Image>().fillAmount = 0;
        }

    }
}
