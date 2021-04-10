using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Button button;
    public Slider slider;
    public Text Text;
    CanvasGroup canvgrp1;
    public Sprite offbutton;
    public Sprite onbutton;

    public void BGMbutton(Text text)
    {
        if (PlayerPrefs.GetInt("BGM")== 1)
        {

            PlayerPrefs.SetInt("BGM", -1);

            this.gameObject.GetComponent<Image>().sprite = offbutton;
        }
        else if (PlayerPrefs.GetInt("BGM") == -1)
        {

            PlayerPrefs.SetInt("BGM", 1);

            this.gameObject.GetComponent<Image>().sprite = onbutton;
        }
    }

    public void SFXbutton()
    {
        if (PlayerPrefs.GetInt("SFX") == 1)
        {

            PlayerPrefs.SetInt("SFX", -1);
            this.gameObject.GetComponent<Image>().sprite = offbutton;

        }
        else if (PlayerPrefs.GetInt("SFX") == -1)
        {

            PlayerPrefs.SetInt("SFX", 1);
            this.gameObject.GetComponent<Image>().sprite = onbutton;

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


    public void subsettingNavigation(GameObject subjectCanvas)
    {
        this.gameObject.SetActive(false);
        subjectCanvas.SetActive(true);
    }

    public void returntoGame()
    {
        this.gameObject.SetActive(false);
    }
    public void secretsauce()
    {
        Debug.Log("Secret Sauce Nothing else here - M");
    }

    private void Update()
    {
        if (this.gameObject.activeInHierarchy == false)
        {
            this.canvgrp1.alpha = 0;
        }
        if (this.gameObject.activeInHierarchy == true)
        {
            this.canvgrp1.alpha = 1;
        }
    }

    private void Start()
    {

        canvgrp1 = this.gameObject.GetComponent<CanvasGroup>();

    }

}
