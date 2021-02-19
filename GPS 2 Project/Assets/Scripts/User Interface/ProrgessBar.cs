using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProrgessBar : MonoBehaviour
{
    public GameObject SearchableObjectWindow;
    public bool showWindow = false;
    public bool stopFilling = false;

    public Transform text;
    public Transform progressBar;
    public Transform player;

    [SerializeField] private float currentTime;
    [SerializeField] private float speed;

    IEnumerator stopBoolean()
    {
        yield return new WaitForSeconds(0.01f);
        showWindow = false;
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {
        if(stopFilling == false)
        {
            //CheckDistance.nearPlayer == true
            if (GameObject.Find("SelectedManager").GetComponent<InteractableItem>().clickOnObject == true)
            {
                gameObject.SetActive(true);
                if (currentTime <= GameObject.Find("SelectedManager").GetComponent<InteractableItem>().progressTime)
                {
                    currentTime += speed * Time.deltaTime;
                    text.GetComponent<Text>().text = ((int)currentTime).ToString();

                }
                progressBar.GetComponent<Image>().fillAmount = currentTime / GameObject.Find("SelectedManager").GetComponent<InteractableItem>().progressTime;

                if (currentTime >= GameObject.Find("SelectedManager").GetComponent<InteractableItem>().progressTime)
                {
                    stopFilling = true;
                    showWindow = true;

                    SearchableObjectWindow.SetActive(true);

                    StartCoroutine(stopBoolean());
                }

            }

            if (GameObject.Find("SelectedManager").GetComponent<InteractableItem>().clickOnObject == false)
            {
                currentTime = 0;
                //text.GetComponent<Text>().text = ((int)currentTime).ToString();
                progressBar.GetComponent<Image>().fillAmount = 0;
            }

        }
        

    }



    public void SearchableObjectWindow_ExitButton()
    {
        print(SearchableObjectWindow.activeSelf ? "Active" : "Inactive");
        showWindow = false;
        stopFilling = false;
        currentTime = 0;

        SearchableObjectWindow.SetActive(false);
    }
}
