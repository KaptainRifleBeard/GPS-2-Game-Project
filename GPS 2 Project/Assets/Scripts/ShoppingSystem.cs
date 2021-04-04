using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class ShoppingSystem : MonoBehaviour
{

    bool itemBought = false;
    public int itemPrice;
    public string itemName;
    public Text PlayerMoney;
    public string pMoney;


    // Start is called before the first frame update
    void Awake()
    {
        if (this.itemBought == true)
        {
            this.gameObject.SetActive(false);
        }
        else if (this.itemBought == false)
        {
            this.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame

    public void buyItem()
    {
        if (PlayerPrefs.GetInt("PlayerMoney",0) >= itemPrice )
        {
            PlayerPrefs.SetInt("PlayerMoney", PlayerPrefs.GetInt("PlayerMoney", 0) - itemPrice);

            this.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Not Enough Money");
        }
    }




    void Update()
    {



        PlayerMoney.text = PlayerPrefs.GetInt("PlayerMoney", 0).ToString();

        

        if (this.itemBought == true)
        {
            this.gameObject.SetActive(false);
        }
    }
}
