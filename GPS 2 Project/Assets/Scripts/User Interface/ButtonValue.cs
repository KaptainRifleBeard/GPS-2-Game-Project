using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonValue : MonoBehaviour
{
    public Text n;
    public Text value;
    public Text space;
    bool openButton;

    public Text pocketName;
    public Text pocketValue;
    public Text pocketSpace;

    public void TakeButton(Button button)
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


        if (n.text == " ")
        {
            button.interactable = false;
        }
        if (n.text != " ")
        {
            button.interactable = true;
        }


        if (SearchWindow.totalSafeCount + SearchWindow.num <= SearchWindow.maxSafeCount)
        {
            pocketName.text = n.text;
            pocketValue.text = value.text;
            pocketSpace.text = space.text;

            n.text = " ";
            value.text = " ";
            space.text = " ";
            
            Debug.Log("Button : " + SearchWindow.num);
            SearchWindow.totalSafeCount += SearchWindow.num;
        }

        
    }

    public void PutButton()
    {
        if(SearchWindow.totalSafeCount > 0)
        {
            AboutSpace();
            pocketName.text = " ";
            pocketValue.text = " ";
            pocketSpace.text = " ";

            n.text = pocketName.text;
            value.text = pocketValue.text;
            space.text = pocketSpace.text;


        }
        if (SearchWindow.totalSafeCount < 0)
        {
            SearchWindow.totalSafeCount = 0;
        }
    }

    public void AboutSpace()
    {
        //Debug.Log("Button : " + num);

        if (pocketName.text == "Wrist Watch" || pocketName.text == "Wedding Diamond Ring" || pocketName.text == "Crystal gem studded hanging earring" ||
           pocketName.text == "Silver pocket watch" || pocketName.text == "Gold and Jade Necklace")
        {
            SearchWindow.totalSafeCount -= 1;
        }

        if (pocketName.text == "Designer sunglasses" || pocketName.text == "Cashmere designer pink shawl" || pocketName.text == "Pendant locket necklace" ||
           pocketName.text == "Gold and diamond  bracelet" || pocketName.text == "Mobile Phone" || pocketName.text == "Antique intricately engraved large pocket watch")
        {
            SearchWindow.totalSafeCount -= 2;
        }

        if (pocketName.text == "Gold ceramic cigar tray" || pocketName.text == "Designer female tote bag" || pocketName.text == "Small wooden antique clock" ||
           pocketName.text == "Double crystal drinking glass" || pocketName.text == "Antique Malaysian wooden smoking pipe")
        {
            SearchWindow.totalSafeCount -= 3;
        }

        if (pocketName.text == "Antique golden candle holder" || pocketName.text == "Small abstract glass male and female sculpture" || pocketName.text == "Female hand painted porcelain figurine" ||
           pocketName.text == "Golden diamond encrusted wedding tiara")
        {
            SearchWindow.totalSafeCount -= 4;
        }

        if (pocketName.text == "High end Laptop" || pocketName.text == "Antique decorative plate" || pocketName.text == "Antique Silver gold encrusted teapot" ||
           pocketName.text == "Golden Dragon Statue")
        {
            SearchWindow.totalSafeCount -= 5;
        }
    }


}
