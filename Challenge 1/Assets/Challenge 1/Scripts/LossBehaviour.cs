/*
 * Gregory Blevins
 * Challenge 1
 * Checks if the player has lost
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossBehaviour : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y>80 || transform.position.y < -51)
        {
            ScoreManager.gameOver = true;
        }
    }
}
