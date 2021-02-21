using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonValue : MonoBehaviour
{
    public Text n;
    
    public void TakeButton()
    {
        if (n.text == "Wrist Watch" || n.text == "Wedding Diamond Ring" || n.text == "Crystal gem studded hanging earring" ||
              n.text == "Silver pocket watch" || n.text == "Gold and Jade Necklace")
        {
            SearchWindow.num = 1;
        }

        if (n.text == "Designer sunglasses" || n.text == "Cashmere designer pink shawl" || n.text == "Pendant locket necklace" ||
           n.text == "Gold and diamond  bracelet" || n.text == "Mobile Phone" || n.text == "Antique intricately engraved large pocket watch")
        {
            SearchWindow.num = 2;

        }

        if (n.text == "Gold ceramic cigar tray" || n.text == "Designer female tote bag" || n.text == "Small wooden antique clock" ||
           n.text == "Double crystal drinking glass" || n.text == "Antique Malaysian wooden smoking pipe")
        {
            SearchWindow.num = 3;

        }

        if (n.text == "Antique golden candle holder" || n.text == "Small abstract glass male and female sculpture" || n.text == "Female hand painted porcelain figurine" ||
           n.text == "Golden diamond encrusted wedding tiara")
        {
            SearchWindow.num = 4;

        }

        if (n.text == "High end Laptop" || n.text == "Antique decorative plate" || n.text == "Antique Silver gold encrusted teapot" ||
           n.text == "Golden Dragon Statue")
        {
            SearchWindow.num = 5;

        }


        if (SearchWindow.total + SearchWindow.num <= SearchWindow.maxPocket)
        {
            Debug.Log("Button : " + SearchWindow.num);

            SearchWindow.total += SearchWindow.num;
        }

    }

}
