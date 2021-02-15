using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject[] prefabs;

    void Start()
    {
        
    }


    void Update()
    {
        /*
        int randPref = Random.Range(0, prefabs.Length);
        int randSpawn = Random.Range(0, spawnPoint.Length);

        Instantiate(prefabs[randPref], spawnPoint[randSpawn].position, transform.rotation);
        */
    }
}
