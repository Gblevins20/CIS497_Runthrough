/*
 * Gregory Blevins
 * Challenge 2
 * Contains Player dog spawning controls
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float spaceCooldown = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && spaceCooldown <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            spaceCooldown = 2f;
        }


        spaceCooldown = spaceCooldown - (1 * Time.deltaTime);
    }
}
