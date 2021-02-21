using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    public float progressTime = 0f;
    public float range = 3f;

    public Transform player;
    public Transform item;

    public bool clickOnObject;

    //show Progress bar
    public GameObject bar;
    public ProrgessBar Progressbar;


    public void Update()
    {
        
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //set item wait time
                if (hit.collider.name == "Bed")
                {
                    item = GameObject.Find("Bed").transform;
                    progressTime = 6f;
                }
                if (hit.collider.name == "Wardrobe")
                {
                    item = GameObject.Find("Wardrobe").transform;
                    progressTime = 5f;
                }
                if (hit.collider.name == "Study Desk")
                {
                    item = GameObject.Find("Study Desk").transform;
                    progressTime = 5f;
                }
                if (hit.collider.name == "Nightstand")
                {
                    item = GameObject.Find("Nightstand").transform;
                    progressTime = 5f;
                }
            }
        }

        if (Progressbar.showWindow == true)
        {
            clickOnObject = false;
        }



        if (Vector3.Distance(player.position, item.position) < 2f)
        {
            bar.SetActive(true);
            clickOnObject = true;
        }
        else
        {
            item = GameObject.Find("Default (to avoid error msg)").transform;
            clickOnObject = false;
            bar.SetActive(false);

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


