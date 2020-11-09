/*
 * Gregory Blevins
 * Prototype 4
 * Handles Camera Controls, Scene, and Display conditions
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RotateCamera: MonoBehaviour
{
    public float rotationSpeed;

    public Text gameStateText, waveText;

    SpawnManager scoreTracker;

    bool gameWin = false;

    // Start is called before the first frame update
    void Start()
    {
        scoreTracker = FindObjectOfType<SpawnManager>();

        waveText.text = "Wave: " + scoreTracker.waveNumber;

        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);

        if (gameWin == true && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void UpdateScore()
    {
        waveText.text = "Wave: " + scoreTracker.waveNumber;

        if (scoreTracker.waveNumber >= 10)
        {
            GameWin();
        }
    }

    void GameWin()
    {
        gameStateText.text = "You Win!\nPress R to Restart!";
        gameWin = true;
        gameStateText.gameObject.SetActive(true);
        scoreTracker.keepSpawning = false;
        Time.timeScale = 0;
    }

    public void GameLoss()
    {
        gameStateText.text = "You Lost!\nPress R to Restart!";
        gameWin = true;
        gameStateText.gameObject.SetActive(true);
        scoreTracker.keepSpawning = false;
        Time.timeScale = 0;
    }
}
