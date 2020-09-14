/*
 * Gregory Blevins
 * Challenge 2
 * Manages scoring instances and handles prefab collision
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<ScoreManager>().addScore();
        Destroy(gameObject);
    }
}
