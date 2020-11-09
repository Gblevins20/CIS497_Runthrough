/*
 * Gregory Blevins
 * Challenge 4
 * Handles loss condition checking
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehaviour : MonoBehaviour
{
    private SpawnManagerX test;

    private int soccerCount, collisionCount;


    // Start is called before the first frame update
    void Start()
    {
        test = FindObjectOfType<SpawnManagerX>();
        collisionCount = 0;
        soccerCount = 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collisionCount++;
        }
    }

    public bool LossCondition()
    {
        if (collisionCount == soccerCount)
        {
            return true;
        }


        return false;
    }

    public void UpdateValues()
    {
        collisionCount = 0;
        soccerCount = test.enemyCount;
    }
}
