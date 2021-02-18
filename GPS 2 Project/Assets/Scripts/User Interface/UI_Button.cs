using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Button : MonoBehaviour
{
    public GameObject SearchableObjectWindow;

    public void SearchableObjectWindow_ExitButton()
    {
        Debug.Log("button click");
        SearchableObjectWindow.SetActive(false);
    }
}
