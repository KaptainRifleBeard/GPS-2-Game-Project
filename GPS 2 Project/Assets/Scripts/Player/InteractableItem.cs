using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractableItem : MonoBehaviour
{
    public float prorgessTime = 0f;
    public Transform player;
    public Transform item;

    public void Update()
    {
        
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            
            if (Physics.Raycast(ray, out hit))
            {
                //set item wait time
                if(hit.collider.name == "Bed")
                {
                    item = GameObject.Find("Bed").transform;
                    if (Vector3.Distance(player.position, item.position) < 1.0f)
                    {
                        prorgessTime = 6f;
                    }

                }
                if (hit.collider.name == "Wardrobe")
                {
                    item = GameObject.Find("Wardrobe").transform;
                    if (Vector3.Distance(player.position, item.position) < 1.0f)
                    {
                        prorgessTime = 5f;
                    }

                }




                //check hit what
                if (hit.collider.CompareTag("Interactable"))
                {
                    Debug.Log(hit.collider.name + " clicked");


                }
            }
        }
    }
}



/*  
 * 
 *  
 *  
    [SerializeField]private GameObject item;
    [SerializeField] private string interactableTag = "Interactable";
    public GameObject player;

    private Color originalColor;
    private Color interactColor;

    Vector3 touchPosWorld;
    TouchPhase touchPhase = TouchPhase.Ended;

    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    private Transform currSelected;

 private void Start()
    {
        item = GameObject.FindGameObjectWithTag(interactableTag);
    }

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


