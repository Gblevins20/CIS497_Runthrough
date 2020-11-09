/*
 * Gregory Blevins
 * Challenge 4
 * Handles Spawning Behaviour of all prefabs, and tracks current waves
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;

    private float spawnRangeX = 10;
    private float spawnZMin = 15; // set min spawn Z
    private float spawnZMax = 25; // set max spawn Z

    public int enemyCount;
    public int waveCount = 1;

    public float speed;

    public GameObject player;

    public Text waveText, gameStateText;
    public bool gameOver = false;
    private bool startDelay = false;

    GoalBehaviour testCondition;

    private void Start()
    {
        testCondition = FindObjectOfType<GoalBehaviour>();

        speed = enemyPrefab.GetComponent<EnemyX>().speed;

        waveText.text = "Wave: " + waveCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (waveCount==1 && !startDelay)
        {
            FreezeStart();
        }

        if (Input.GetKeyDown(KeyCode.Space) && enemyCount == 1 && startDelay)
        {
            StartGame();
        }

        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (enemyCount == 0)
        {
            
            SpawnEnemyWave(waveCount);
            if (testCondition.LossCondition())
            {
                GameLoss();
            }
            testCondition.UpdateValues();
        }

        if(gameOver && Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    private void StartGame()
    {
        Time.timeScale = 1;
        gameStateText.gameObject.SetActive(false);
    }

    void GameWin()
    {
        gameStateText.text = "You Win!\nPress R to Restart!";
        gameOver = true;
        gameStateText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    void GameLoss()
    {
        gameStateText.text = "You Lose!\nPress R to Restart!";
        gameOver = true;
        gameStateText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    void FreezeStart()
    {
        Time.timeScale = 0;
        startDelay = true;
    }

    // Generate random spawn position for powerups and enemy balls
    Vector3 GenerateSpawnPosition ()
    {
        float xPos = Random.Range(-spawnRangeX, spawnRangeX);
        float zPos = Random.Range(spawnZMin, spawnZMax);
        return new Vector3(xPos, 0, zPos);
    }


    void SpawnEnemyWave(int enemiesToSpawn)
    {
        speed+=3;
        Vector3 powerupSpawnOffset = new Vector3(0, 0, -15); // make powerups spawn at player end

        // If no powerups remain, spawn a powerup
        if (GameObject.FindGameObjectsWithTag("Powerup").Length == 0) // check that there are zero powerups
        {
            Instantiate(powerupPrefab, GenerateSpawnPosition() + powerupSpawnOffset, powerupPrefab.transform.rotation);
        }

        // Spawn number of enemy balls based on wave number
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }

        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        waveText.text = "Wave: " + waveCount;

        if (waveCount == 10)
        {
            GameWin();
        }

        waveCount++;
        ResetPlayerPosition(); // put player back at start 
    }

    // Move player back to position in front of own goal
    void ResetPlayerPosition ()
    {
        player.transform.position = new Vector3(0, 1, -7);
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

    }

}
