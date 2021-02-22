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
                if (hit.collider.name == "Large Wardrobe")
                {
                    item = GameObject.Find("Large Wardrobe").transform;
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
                if (hit.collider.name == "Master Bed")
                {
                    item = GameObject.Find("Master Bed").transform;
                    progressTime = 6f;
                }
                if (hit.collider.name == "Nightstand 2")
                {
                    item = GameObject.Find("Nightstand 2").transform;
                    progressTime = 5f;
                }
                if (hit.collider.name == "Small Wardrobe")
                {
                    item = GameObject.Find("Small Wardrobe").transform;
                    progressTime = 5f;
                }
                if (hit.collider.name == "Kitchen Cabinet")
                {
                    item = GameObject.Find("Kitchen Cabinet").transform;
                    progressTime = 3f;
                }
                if (hit.collider.name == "Kitchen Counter")
                {
                    item = GameObject.Find("Kitchen Counter").transform;
                    progressTime = 5f;
                }
                if (hit.collider.name == "Floating Shelf")
                {
                    item = GameObject.Find("Floating Shelf").transform;
                    progressTime = 3f;
                }
                if (hit.collider.name == "Floating Shelf 2")
                {
                    item = GameObject.Find("Floating Shelf 2").transform;
                    progressTime = 3f;
                }
                if (hit.collider.name == "Safe Vault")
                {
                    item = GameObject.Find("Safe Vault").transform;
                    progressTime = 8f;
                }
                if (hit.collider.name == "Triple_Seater_Sofa")
                {
                    item = GameObject.Find("Triple_Seater_Sofa").transform;
                    progressTime = 6f;
                }
                if (hit.collider.name == "Compartmental_Coffee_Table")
                {
                    Debug.Log("clicked");
                    Debug.Log(hit.collider.name);

                    item = GameObject.Find("Compartmental_Coffee_Table").transform;
                    progressTime = 5f;
                }
                if (hit.collider.name == "TV_Cabinet")
                {
                    item = GameObject.Find("TV_Cabinet").transform;
                    progressTime = 5f;
                }

            }
        }

        if (Progressbar.showWindow == true)
        {
            clickOnObject = false;

        }


        if (Vector3.Distance(player.position, item.position) < 150f)
        {
            Debug.Log("show bar");
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


