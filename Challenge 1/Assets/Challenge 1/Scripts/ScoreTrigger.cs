/*
 * Gregory Blevins
 * Challenge 1
 * Increments score in scoremanager for player fly past obstacles
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            ScoreManager.count++;
            triggered = true;
        }
    }
}
