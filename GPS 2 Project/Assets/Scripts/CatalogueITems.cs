using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CatalogueITems : MonoBehaviour
{
    public int price;
    public Text Name;
    public Text Price;
    public string itemname;
    int ItemCountleft = 1;
    static bool Equipped = false;


    // check if adam wants the sold out items to be removed or be drawn as sold out.

   public void bought()
    {
        if (PlayerPrefs.GetInt("PlayerMoney",0)>= price && ItemCountleft>0)
        {
            PlayerPrefs.SetInt("PlayerMoney", PlayerPrefs.GetInt("PlayerMoney", 0) - price);
            ItemCountleft -= 1;
        }
        else if (Equipped == true)
        {
            unequip();
        }
        else
        {
            equip();
        }
    }
   

    void equip()
    {
        Equipped = true;
        this.GetComponentInChildren<Text>().text = "Un-equip";
        //Wait for thea to insert ITEM into equip inventory.

        // passover item into equip inventory.
    }

    void unequip()
    {
        Equipped = false;
        this.GetComponentInChildren<Text>().text = "Equip";
        // wait for thea to remove item from inventory


    }
    // Start is called before the first frame update
    void Start()
    {
        name = itemname;
        this.GetComponentInChildren<Text>().text = "Buy RM"+price;
        Price.text = price.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (ItemCountleft == 0)
        {
            this.GetComponentInChildren<Text>().text = "Equip";
        }
    }
}
