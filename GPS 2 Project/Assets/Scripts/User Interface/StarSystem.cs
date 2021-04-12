using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarSystem : MonoBehaviour
{
    public static int num = 0;

    public GameObject[] level1Star;
    public Sprite emptyStar;
    public Image star1;
    public Image star2;
    public Image star3;

    void Start()
    {
        num = PlayerPrefs.GetInt("Level1Star");
    }

    void Update()
    {
        if (num == 0)
        {
            star1.sprite = emptyStar;
            star2.sprite = emptyStar;
            star3.sprite = emptyStar;

        }
        if (num == 1)
        {
            star2.sprite = emptyStar;
            star3.sprite = emptyStar;

            level1Star[1].SetActive(true);
        }
        if (num == 2)
        {
            star3.sprite = emptyStar;

            level1Star[1].SetActive(true);
            level1Star[2].SetActive(true);
        }
        if (num == 3)
        {
            level1Star[1].SetActive(true);
            level1Star[2].SetActive(true);
            level1Star[3].SetActive(true);
        }
    }
}
