using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelSelect1 : MonoBehaviour
{
    private bool unlocked;
    private int levelCompleted = 0;

   // public int LevelSelected;
    public int ThisLevel;

    public Sprite star;
    public Sprite Locked;
    public Sprite star1, star2, star3;


    public void MenuNav(int chosen)
    {
        SceneManager.LoadScene(chosen);
    }


    public void clicked(int nextLevel)
    {
        if (ThisLevel - levelCompleted >= -1)
        {
            SceneManager.LoadScene(nextLevel);
        }   else
        {
            return;
        }
    }

    public void clearLevel(int starLevel)
    {
        if (starLevel == 1)
        {
            this.gameObject.GetComponent<Image>().sprite = star1;

        }
        else if (starLevel ==2)
        {
            this.gameObject.GetComponent<Image>().sprite = star2;
        }
        else if (starLevel ==3)
        {
            this.gameObject.GetComponent<Image>().sprite = star3;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (levelCompleted - ThisLevel >= 1)
        {
            this.gameObject.GetComponent<Image>().sprite = star;
        }else if (levelCompleted - ThisLevel >= 1)
        {
            this.gameObject.GetComponent<Image>().sprite = Locked;
        }


    }
}
