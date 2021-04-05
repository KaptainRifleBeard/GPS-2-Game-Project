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
    public int ItemCountleft;


    // check if adam wants the sold out items to be removed or be drawn as sold out.

    void bought()
    {
        if (PlayerPrefs.GetInt("PlayerMoney",0)>= price)
        {
            PlayerPrefs.SetInt("PlayerMoney", PlayerPrefs.GetInt("PlayerMoney", 0) - price);
            ItemCountleft -= 1;
        }
        else
        {
            return;
        }
    }
   
    // Start is called before the first frame update
    void Start()
    {
        name = itemname;

        Price.text = price.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (ItemCountleft == 0)
        {
            Destroy(this);
        }
    }
}
