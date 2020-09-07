/*
 * Gregory Blevins
 * Prototype 1
 * Handles Car movement based on player input
 */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move Forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);


    }
}
