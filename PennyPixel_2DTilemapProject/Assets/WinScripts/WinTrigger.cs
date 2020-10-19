/*
 * Gregory Blevins
 * Penny Pixel Project
 * Controls the winning text
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{

    public Text winText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            winText.gameObject.SetActive(true);
        }
    }
}
