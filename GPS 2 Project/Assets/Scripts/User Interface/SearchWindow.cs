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
    public static int maxSafeCount = 5;
    public static int maxPocket = 5;

    public static int totalSafeCount = 0;
    int calculateSpaceUsed;

    int i;
    int rand;

    [SerializeField ]public static int num;


    [Header("List of the items")]
    [Space(50)]
    public List<WindowManager> windowManage = new List<WindowManager>();

    public string[] itemName;

    public void Start()
    {
        AboutSpace();
    }

    public void Update()
    {
        if (bar.showWindow == true)
        {

            AboutValue();
            //AboutSpace();

            for (int i = 0; i < rand; i++)
            {
                //n.text = windowManage[i].itemName;

                //value.text = windowManage[i].itemValue;
                //space.text = "Space used:  " + num.ToString();
            }
            
        }


    }

    public void AboutSpace()
    {
        //Debug.Log("Button : " + num);

        if (n.text == "Wrist Watch" || n.text == "Wedding Diamond Ring" || n.text == "Crystal gem studded hanging earring" ||
           n.text == "Silver pocket watch" || n.text == "Gold and Jade Necklace")
        {
            num = 1;
        }

        if (n.text == "Designer sunglasses" || n.text == "Cashmere designer pink shawl" || n.text == "Pendant locket necklace" ||
           n.text == "Gold and diamond  bracelet" || n.text == "Mobile Phone" || n.text == "Antique intricately engraved large pocket watch")
        {
            num = 2;

        }

        if (n.text == "Gold ceramic cigar tray" || n.text == "Designer female tote bag" || n.text == "Small wooden antique clock" ||
           n.text == "Double crystal drinking glass" || n.text == "Antique Malaysian wooden smoking pipe")
        {
            num = 3;

        }

        if (n.text == "Antique golden candle holder" || n.text == "Small abstract glass male and female sculpture" || n.text == "Female hand painted porcelain figurine" ||
           n.text == "Golden diamond encrusted wedding tiara")
        {
            num = 4;

        }

        if (n.text == "High end Laptop" || n.text == "Antique decorative plate" || n.text == "Antique Silver gold encrusted teapot" ||
           n.text == "Golden Dragon Statue")
        {
            num = 5;

        }
    }

    public void AboutValue()
    {
        rand = Random.Range(1, itemName.Length);


        if (rand == 1)
        {
            n.text = "Wrist Watch";
            value.text = "RM 300";
            space.text = "Space used:  " + 1.ToString();
            AboutSpace();
        }

        if (rand == 2)
        {

            n.text = "Wedding Diamond Ring";
            value.text = "RM 595";
            space.text = "Space used:  " + 1.ToString();
            AboutSpace();
        }

        if (rand == 3)
        {

            n.text = "Crystal gem studded hanging earring";
            value.text = "RM 895"; 
            space.text = "Space used:  " + 1.ToString();

            AboutSpace();
        }

        if (rand == 4)
        {
            n.text = "Silver pocket watch";
            value.text = "RM 901";
            space.text = "Space used:  " + 1.ToString();
            AboutSpace();
        }

        if (rand == 5)
        {
            n.text = "Designer sunglasses";
            value.text = "RM 1,050";
            space.text = "Space used:  " + 2.ToString();
            AboutSpace();
        }

        if (rand == 6)
        {
            n.text = "Cashmere designer pink shawl";
            value.text = "RM 1,178";
            space.text = "Space used:  " + 2.ToString();
            AboutSpace();
        }

        if (rand == 7)
        {
            n.text = "Pendant locket necklace";
            value.text = "RM 1,119";
            space.text = "Space used:  " + 2.ToString();
            AboutSpace();

        }

        if (rand == 8)
        {
            n.text = "Gold and diamond  bracelet";
            value.text = "RM 1,595";
            space.text = "Space used:  " + 2.ToString();
            AboutSpace();

        }

        if (rand == 9)
        {
            n.text = "Mobile Phone";
            value.text = "RM 1,673";
            space.text = "Space used:  " + 2.ToString();
            AboutSpace();

        }

        if (rand == 10)
        {
            n.text = "Gold ceramic cigar tray";
            value.text = "RM 1,765";
            space.text = "Space used:  " + 3.ToString();
            AboutSpace();

        }

        if (rand == 11)
        {
            n.text = "Designer female tote bag";
            value.text = "RM 1,845";
            space.text = "Space used:  " + 3.ToString();
            AboutSpace();


        }

        if (rand == 12)
        {
            n.text = "Small wooden antique clock";
            value.text = "RM 2,120";
            space.text = "Space used:  " + 3.ToString();
            AboutSpace();

        }

        if (rand == 13)
        {
            n.text = "Double crystal drinking glass";
            value.text = "RM 2,890";
            space.text = "Space used:  " + 3.ToString();
            AboutSpace();

        }

        if (rand == 14)
        {
            n.text = "Small Chinese motif porcelain vase";
            value.text = "RM 3,210";
            space.text = "Space used:  " + 4.ToString();
            AboutSpace();

        }

        if (rand == 15)
        {
            n.text = "Antique golden candle holder";
            value.text = "RM 3,298";
            space.text = "Space used:  " + 4.ToString();
            AboutSpace();


        }

        if (rand == 16)
        {
            n.text = "Small abstract glass male and female sculpture";
            value.text = "RM 3,598";
            space.text = "Space used:  " + 4.ToString();
            AboutSpace();

        }

        if (rand == 17)
        {
            n.text = "Female hand painted porcelain figurine";
            value.text = "RM 4,100";
            space.text = "Space used:  " + 4.ToString();
            AboutSpace();

        }

        if (rand == 18)
        {
            n.text = "High end Laptop";
            value.text = "RM 5,189";
            space.text = "Space used:  " + 5.ToString();
            AboutSpace();

        }

        if (rand == 19)
        {
            n.text = "Antique decorative plate";
            value.text = "RM 5,345";
            space.text = "Space used:  " + 5.ToString();
            AboutSpace();


        }

        if (rand == 20)
        {
            n.text = "Antique Silver gold encrusted teapot";
            value.text = "RM 5,645";
            space.text = "Space used:  " + 5.ToString();
            AboutSpace();


        }

        if (rand == 21)
        {
            n.text = "Gold and Jade Necklace";
            value.text = "RM 895";
            space.text = "Space used:  " + 1.ToString();
            AboutSpace();


        }
        if (rand == 22)
        {
            n.text = "Antique intricately engraved large pocket watch";
            value.text = "RM 1,989";
            space.text = "Space used:  " + 2.ToString();

            AboutSpace();

        }

        if (rand == 23)
        {
            n.text = "Antique Malaysian wooden smoking pipe";
            value.text = "RM 2,495";
            space.text = "Space used:  " + 3.ToString();
            AboutSpace();


        }

        if (rand == 24)
        {
            n.text = "Golden diamond encrusted wedding tiara";
            value.text = "RM 3,982";
            space.text = "Space used:  " + 4.ToString();

            AboutSpace();

        }

        if (rand == 25)
        {

            n.text = "Golden Dragon Statue";
            value.text = "RM 5,145";
            space.text = "Space used:  " + 5.ToString();

            AboutSpace();

        }
    }


}
