using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n_ButtonItemPool : MonoBehaviour
{
    public GameObject prefabs;
    private Stack<GameObject> inactiveInstances = new Stack<GameObject>();  //collection of currently inactive instance prefabs
    
    public GameObject GetItem()
    {
        GameObject spawnedItem;
        if(inactiveInstances.Count > 0)  //if there is a inactive instance to return
        {
            spawnedItem = inactiveInstances.Pop();
        }
        else //new instance
        {

            spawnedItem = (GameObject)GameObject.Instantiate(prefabs, transform.parent);

            PooledObject poolObject = spawnedItem.AddComponent<PooledObject>();
            poolObject.pool = this;
            
        }

        //put instance in the root
        spawnedItem.transform.SetParent(null);
        spawnedItem.SetActive(true);
        return spawnedItem;
    }

    public void ReturnItems(GameObject toReturn)
    {
        PooledObject pooledObject = toReturn.GetComponent<PooledObject>();

        if(pooledObject != null && pooledObject.pool == this)
        {
            //make the instance a child
            toReturn.transform.SetParent(transform);
            toReturn.SetActive(false);

            //add instance to the inactive instance
            inactiveInstances.Push(toReturn);
        }
        else
        {
            Destroy(toReturn);
        }
    }

    public class PooledObject : MonoBehaviour
    {
        public n_ButtonItemPool pool;
    }
}
