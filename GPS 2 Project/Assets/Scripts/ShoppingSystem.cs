using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class ShoppingSystem : MonoBehaviour
{

    bool itemBought = false;
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





    void Update()
    {



        PlayerMoney.text = PlayerPrefs.GetInt("PlayerMoney", 0).ToString();
    }
}
