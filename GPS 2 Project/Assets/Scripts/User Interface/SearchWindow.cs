using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SearchWindow : MonoBehaviour
{
    public Text n;
    public Text value;
    public Text space;

    public ProrgessBar bar;
    public static int maxPocket = 5;
    public Text maxSpace;

    public static int total;

    int i;
    public int num;


    [Header("List of the items")]
    [Space(50)]
    public List<WindowManager> windowManage = new List<WindowManager>();
   

    private void Start()
    {

    }

    public void Update()
    {

        if (bar.showWindow == true)
        {
            maxSpace.text = " / " +  maxPocket.ToString();

            //! check level int to determine rand value, each level have diff amount
            //! SET setSctive to limit panel amount show
            int rand = Random.Range(1, windowManage.Count);

            for (i = 1; i < rand; i++)
            {
                n.text = windowManage[i].itemName;
                value.text = windowManage[i].itemValue;

                num = windowManage[i].spaceNeed;
                space.text = windowManage[i].spaceNeed.ToString();

            }

           
        }
    }


    public void TakeButton()
    {
        Debug.Log(num);

        if (total < maxPocket)
        {
            total += num;
        }
    }
}
