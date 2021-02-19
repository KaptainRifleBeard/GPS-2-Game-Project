using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SearchWindow : MonoBehaviour
{
    public Text name;
    public Text value;
    public Text space;


    public ProrgessBar bar;
    public Text spaceCount;
    private int spaceUsedPocket;
    private int maxPocket = 5;


    [Header("List of the items")]
    [Space(50)]
    public List<WindowManager> windowManage = new List<WindowManager>();
    


    private void Update()
    {
        if (bar.showWindow == true)
        {

            //! check level int to determine rand value, each level have diff amount
            //! SET setSctive to limit panel amount show
            int rand = Random.Range(1, windowManage.Count);

            for(int i = 0; i < rand; i++)
            {
                name.text = windowManage[i].itemName;
                value.text = windowManage[i].itemValue;
                space.text = windowManage[i].spaceNeed.ToString();
            }
            spaceCount.GetComponent<Text>().text = spaceUsedPocket.ToString() + " / " + maxPocket.ToString();
        }
    }

}
