using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractableItem : MonoBehaviour
{
    [SerializeField] private string interactableTag = "Interactable";
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    private Transform currSelected;
    public GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name == "Player")
        {

        }
    }

    public void Update()
    {
        //Deselect item
        if (currSelected != null)
        {
            var selectionRenderer = currSelected.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            currSelected = null;
        }


        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(interactableTag))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    Debug.Log(highlightMaterial);
                    selectionRenderer.material = highlightMaterial;
                }
                currSelected = selection;
            }
        }

    }
}

   
