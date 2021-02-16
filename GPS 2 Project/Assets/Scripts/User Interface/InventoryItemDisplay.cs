using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemDisplay : MonoBehaviour
{
    public GameObject SearchableObjectWindow;

    public Text textName;
    public Image sprite;

    public string[] itemName;
   

    void Start()
    {
        
    }


    void Update()
    {

        if(GetComponent<ProrgessBar>().showWindow == true)
        {
            SearchableObjectWindow.SetActive(true);
            string name = itemName[Random.Range(0, itemName.Length - 1)];
            textName.text = name.ToString();
        }
       
    }
}
