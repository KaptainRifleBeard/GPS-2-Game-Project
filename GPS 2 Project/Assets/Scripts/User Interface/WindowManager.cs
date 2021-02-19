using UnityEngine;
using System;

[Serializable]
public struct WindowManager
{
    public string itemName;
    public string itemValue;
    public int spaceNeed;
}


/* public class WindowManager : MonoBehaviour
{
    public Text spaceCount;
    public ProrgessBar bar;

    private int maxPocket = 5;
    private int spaceUsedPocket;
    public bool show = false;

    void Start()
    {
        
    }


    void Update()
    {
        if (bar.showWindow == true)
        {
            show = true;
            spaceCount.GetComponent<Text>().text = spaceUsedPocket.ToString() + " / " + maxPocket.ToString();
        }
    }
}  */