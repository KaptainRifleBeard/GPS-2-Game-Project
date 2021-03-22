using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSystem : MonoBehaviour
{
    int num;

    public GameObject[] level1Star;

    void Start()
    {
    }

    void Update()
    {
        num = PlayerPrefs.GetInt("Level1 star");

        if (num == 0)
        {
            level1Star[0].SetActive(false);
            level1Star[0].SetActive(true);
        }
        if (num == 1)
        {
            level1Star[0].SetActive(false);
            level1Star[1].SetActive(true);
        }
        if (num == 2)
        {
            level1Star[0].SetActive(false);
            level1Star[2].SetActive(true);
        }
        if (num == 3)
        {
            level1Star[0].SetActive(false);
            level1Star[3].SetActive(true);
        }
    }
}
