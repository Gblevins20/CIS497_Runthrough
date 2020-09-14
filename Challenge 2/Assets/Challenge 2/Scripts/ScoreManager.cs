/*
 * Gregory Blevins
 * Challenge 2
 * Manages Score Display and Win Condition
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    public GameObject winText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;

        if (score >= 5)
        {
            FindObjectOfType<HealthManager>().gameOver = true;

            winText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }
    }

    public void addScore()
    {
        score++;
    }
}
