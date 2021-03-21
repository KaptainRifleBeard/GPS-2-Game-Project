using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newCheckDistance : MonoBehaviour
{
    //To highlight object
    public Renderer mat;

    public Color highlightColor;
    public List<Color> defaultColor;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            for (int i = 0; i < mat.materials.Length; i++)
            {
                mat.materials[i].color = highlightColor;
            }
        }
    }


    public void OnCollisionExit(Collision collision)
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
