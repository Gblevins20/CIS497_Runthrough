/*
 * Gregory Blevins
 * Assignment 6
 * Abstract Class to handle Enemies
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected int type;
    protected int score;

    protected virtual void Awake()
    {
        type = 0;
        score = 1;
    }

    protected abstract void Attack();

    protected abstract void Movement();
}

