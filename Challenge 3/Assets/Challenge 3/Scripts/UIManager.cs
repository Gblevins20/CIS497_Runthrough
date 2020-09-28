/*
 * Gregory Blevins
 * Challenge 3
 * Handles scoring and player feedback
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;

    public int score = 0;

    private PlayerControllerX gameOver;

    private bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();

        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {

        if (!gameOver.gameOver)
        {
            scoreText.text = "Score: " + score;
        }
        else if (gameOver.gameOver && !won)
        {
            scoreText.text = "Game Over!\nPress R to Try Again!";
        }

        if (score >= 30)
        {
            won = true;
            gameOver.gameOver = true;
            scoreText.text = "You win!\nPress R to Try Again!";
        }


        if (gameOver.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }
}
