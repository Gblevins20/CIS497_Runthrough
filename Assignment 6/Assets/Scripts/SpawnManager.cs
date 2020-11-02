/*
 * Gregory Blevins
 * Assignment 6
 * Handles Enemy Spawning
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> prefabsToSpawn;

    public float timeBetween;
    float placeHold;

    int alternate = 1;

    Vector3 spawnPoint = new Vector3(10, 0, 0);

    private void Start()
    {
        placeHold = timeBetween;
    }

    // Update is called once per frame
    void Update()
    {

        if (timeBetween <= 0)
        {
            Instantiate(prefabsToSpawn[alternate],spawnPoint,prefabsToSpawn[alternate].transform.rotation);

            if (alternate == 1)
            {
                alternate = 0;
            }
            else
            {
                alternate = 1;
            }

            timeBetween = placeHold;
        }


        timeBetween = timeBetween - 1f * Time.deltaTime;
    }
}
