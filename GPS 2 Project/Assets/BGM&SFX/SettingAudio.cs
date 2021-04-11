using System;
using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;

public class SettingAudio : MonoBehaviour
{
    public GameObject settingMenu;

    public static int bgmnum;

    public Sprite OFF;
    public Sprite ON;

    public Image bgmImage;
    public Image sfxImage;

    public static bool onBGM, onSFX;

    public void OpenSettingMenu()
    {
        settingMenu.SetActive(true);
    }
    public void CloseSettingMenu()
    {
        settingMenu.SetActive(false);
    }

    public void sfxButton()
    {
        if (sfxImage.sprite == ON) 
        {
            sfxImage.sprite = OFF;
        }
        else
        {
            sfxImage.sprite = ON;
        }
    }
    public void BGMbutton()
    {
        if (bgmImage.sprite == ON) //bgm
        {
            bgmnum = 0;

            bgmImage.sprite = OFF;
        }
        else
        {
            bgmnum = 1;

            bgmImage.sprite = ON;
        }
    }
    void Start()
    {
        bgmnum = 1;
    }
    public void Update()
    {

        if (sfxImage.sprite == ON) //sfx
        {
            onSFX = false;

        }
        else
        {
            onSFX = true;

        }

    }
}
