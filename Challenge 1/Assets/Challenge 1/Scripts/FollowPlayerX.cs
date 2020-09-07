/*
 * Gregory Blevins
 * Challenge 1
 * Makes Camera Follow the plane
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset;


    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
