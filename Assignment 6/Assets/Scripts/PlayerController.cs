/*
 * Gregory Blevins
 * Assignment 6
 * Handles Player Controls
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int state;

    public GameObject weapon;

    // Start is called before the first frame update
    void Start()
    {
        state = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ChangeHeldItem();
        }

        if (GameManager.Instance.GameFinish && Input.GetKeyDown(KeyCode.G))
        {
            GameManager.Instance.LoadLevel(GameManager.Instance.GetCurrentLevelName());
        }
    }

    void ChangeHeldItem()
    {
        if (state == 1)
        {
            weapon.transform.Rotate(0, 0, 90);
        }
        else if (state == -1)
        {
            weapon.transform.Rotate(0, 0, 0);
        }

        state = -state;
    }
}
