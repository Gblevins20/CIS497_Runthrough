/*
 * Gregory Blevins
 * Challenge 2
 * Manages the spawning of balls
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    public bool gameOver = false;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnRandomBall");
    }

    // Spawn random ball at random x position at top of play area
    IEnumerator SpawnRandomBall ()
    {
        yield return new WaitForSeconds(1.0f);

        while (!gameOver)
        {
            // Generate random ball index and random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

            int randomBall = Random.Range(1, 3);

            float randomInterval = Random.Range(3.0f, 5.0f);

            yield return new WaitForSeconds(randomInterval);

            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[randomBall].transform.rotation);
        }
        
    }

}
