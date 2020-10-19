/*
 * Gregory Blevins
 * Assignment 5
 * Controls Wintext
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Text winText;

    public Image crosshair;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winText.gameObject.SetActive(true);
            crosshair.gameObject.SetActive(false);
        }
    }


}
