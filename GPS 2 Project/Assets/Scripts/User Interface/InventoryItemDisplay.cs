using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemDisplay : MonoBehaviour
{
    //public Text textName;
    public Text spaceCount;

    //public Image sprite;

    //public string[] itemName;
    public ProrgessBar bar;

    private int maxPocket = 5;
    private int spaceUsedPocket;

    void Start()
    {
        
    }


    void Update()
    {
        if(bar.showWindow == true)
        {
            //string name = itemName[Random.Range(0, itemName.Length - 1)];
            //textName.text = name.ToString();

            spaceCount.GetComponent<Text>().text = spaceUsedPocket.ToString() + " / " + maxPocket.ToString();
        }
       
    }
}
