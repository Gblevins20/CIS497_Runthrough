/*
 * Gregory Blevins
 * Assignment 2
 * Controls victory condition
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneScript : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
