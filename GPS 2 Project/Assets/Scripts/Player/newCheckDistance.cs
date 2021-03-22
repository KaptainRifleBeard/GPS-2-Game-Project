using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newCheckDistance : MonoBehaviour
{
    //To highlight object
    public Renderer mat;

    public Color highlightColor;
    public List<Color> defaultColor;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            for (int i = 0; i < mat.materials.Length; i++)
            {
                mat.materials[i].color = highlightColor;
            }
        }
    }


    public void OnTriggerExit(Collider collision)
    {
        if(gameObject.tag != "CleaningTaskObject")
        {
            for (int i = 0; i < mat.materials.Length; i++)
            {
                mat.materials[i].color = defaultColor[i];
            }
        }
        
    }

    void Start()
    {
        for (int i = 0; i < mat.materials.Length; i++)
        {
            defaultColor.Add(mat.materials[i].color);
        }

        if (gameObject.tag == "CleaningTaskObject")
        {
            for (int i = 0; i < mat.materials.Length; i++)
            {
                mat.materials[i].color = highlightColor;
            }
        }

    }

    void Update()
    {
        
    }
}
