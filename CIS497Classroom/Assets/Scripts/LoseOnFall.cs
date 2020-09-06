/*
 * Gregory Blevins
 * Assignment 2
 * Triggers lose condition on vehicle fall
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoseOnFall : MonoBehaviour
{

    // Start is called before the first frame update


    void Update()
    {
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
