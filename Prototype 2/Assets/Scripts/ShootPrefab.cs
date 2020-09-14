/*
 * Gregory Blevins
 * Prototype 2
 * Shoots a prefab object from player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPrefab : MonoBehaviour
{
    public GameObject shootablePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shootablePrefab, transform.position, shootablePrefab.transform.rotation);
        }
        
    }
}
