using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PocketCount : MonoBehaviour
{
    public Text pocketCount;
    public n_ItemsList item;

    int space;

    void Start()
    {
        space = item.space;
    }

    // Update is called once per frame
    void Update()
    {
        pocketCount.text = item.space.ToString();


    }

}
