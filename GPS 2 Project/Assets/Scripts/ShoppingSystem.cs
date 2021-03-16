using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingSystem : MonoBehaviour
{

    bool itemBought = false;
    public int itemPrice;
    public string itemName;
   


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
        if (this.itemBought == true)
        {
            this.gameObject.SetActive(false);
        }
    }
}
