/*
 * Gregory Blevins
 * Challenge 1
 * Rotates propeller on z axis
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningPropeller : MonoBehaviour
{
    public float setSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.position, setSpeed * Time.deltaTime);
    }
}
