using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Button button;
    public Slider slider;
    public Text Text;
    public CanvasGroup canvgrp1;
    public CanvasGroup canvgrp2;

    public void BGMbutton(Text text)
    {
        if (PlayerPrefs.GetInt("BGM")== 1)
        {

            PlayerPrefs.SetInt("BGM", -1);
            
        }
        else if (PlayerPrefs.GetInt("BGM") == -1)
        {

            PlayerPrefs.SetInt("BGM", 1);

        }
    }

    public void SFXbutton()
    {
        if (PlayerPrefs.GetInt("SFX") == 1)
        {

            PlayerPrefs.SetInt("SFX", -1);

        }
        else if (PlayerPrefs.GetInt("SFX") == -1)
        {

            PlayerPrefs.SetInt("SFX", 1);

        }
    }

    public void SFXSlider(Slider slider)
    {
        if (slider.normalizedValue>0.00)
        {

            PlayerPrefs.SetFloat("SFXvolume", slider.normalizedValue);
            PlayerPrefs.SetInt("SFX", 1);

        }
        else if (slider.normalizedValue == 0.00)
        {

            PlayerPrefs.SetFloat("SFXvolume", slider.normalizedValue);
            PlayerPrefs.SetInt("SFX", -1);

        }
    }



    public void BGMSlider(Slider slider)
    {
        if (slider.normalizedValue > 0.00)
        {

            PlayerPrefs.SetFloat("BGMvolume", slider.normalizedValue);
            PlayerPrefs.SetInt("BGM", 1);

        }
        else if (slider.normalizedValue == 0.00)
        {

            PlayerPrefs.SetFloat("BGMvolume", slider.normalizedValue);
            PlayerPrefs.SetInt("BGM", -1);

        }
    }

    public void soundSetting()
    {

    }

    public void subsettingNavigation(GameObject subjectCanvas)
    {
        this.gameObject.SetActive(false);
        subjectCanvas.SetActive(true);
    }

    public void secretsauce()
    {
        Debug.Log("Secret Sauce Nothing else here - M");
    }

}
