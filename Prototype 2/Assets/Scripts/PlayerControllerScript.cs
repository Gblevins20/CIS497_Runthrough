/*
 * Gregory Blevins
 * Prototype 2
 * Controls Player Movement
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 14;


    // Update is called once per frame
    void Update()
    {
        //Get Horizontal inputs
        horizontalInput = Input.GetAxis("Horizontal");

        //Move player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Bounds player movement between xRange values
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
