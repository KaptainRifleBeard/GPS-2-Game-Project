using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PocketCount : MonoBehaviour
{
    public Text currentCap;
    public t_itemList list;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentCap.text = list.pocket_spacecount.ToString() + " / " + 5.ToString();


    }

}
