using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProrgessBar : MonoBehaviour
{
    public Transform text;
    public Transform progressBar;
    public Transform player;

    [HideInInspector] public float currentTime;
    [SerializeField] private float speed;

    public bool showWindow;
    public bool showItemList;
    public GameObject SearchableObjectWindow;


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
            showWindow = true;

            StartCoroutine(stopBoolean());

        }


        if (currentTime >= GameObject.Find("SelectedManager").GetComponent<InteractableItem>().progressTime)
        {
            showItemList = true;
            SearchableObjectWindow.SetActive(true);

        }

    }

    public void SearchableObjectWindow_ExitButton()
    {
        print(SearchableObjectWindow.activeSelf ? "Active" : "Inactive");
        showWindow = false;
        currentTime = 0;

        SearchableObjectWindow.SetActive(false);
    }
}
