using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractableItem : MonoBehaviour
{
    [SerializeField] private string interactableTag = "Interactable";
    public GameObject player;
    [SerializeField]private GameObject item;
    public float range = 0.1f;

    private Color originalColor;
    private Color interactColor;

    Vector3 touchPosWorld;
    TouchPhase touchPhase = TouchPhase.Ended;

    private void Start()
    {
        item = GameObject.FindGameObjectWithTag(interactableTag);
    }


    public void Update()
    {
        /*
        if (Vector3.Distance(player.transform.position, item.transform.position) < range)
        {
            Debug.Log("player is near " + item.name);
        }
        */

        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //OR with Tag
                if (hit.collider.CompareTag("Interactable"))
                {
                    Debug.Log( " clicked");
                    Debug.Log(hit.collider.name + " clicked");
                }
            }
        }
    }
}   



/*
 * 
 *  
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    private Transform currSelected;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name == "Player")
        {

        }
    }

    public void Update()
    {
        //Touch interactable item
       


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
                    selectionRenderer.material = highlightMaterial;
                }
                currSelected = selection;
            }
        }

    }

*/

   
