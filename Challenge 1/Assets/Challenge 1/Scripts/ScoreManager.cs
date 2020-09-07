/*
 * Gregory Blevins
 * Challenge 1
 * Manages victory condition and displays game progress
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool win = false;
    public static int count = 0;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        win = false;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!gameOver)
        {
            scoreText.text = "Score: " + count;
        }

        if (count >= 5)
        {
            gameOver = true;
            win = true;
        }

        if (gameOver)
        {
            if (win)
            {
                scoreText.text = "You win!\nPress R to Try Again!";
            }
            else
            {
                scoreText.text = "You lost!\nPress R to Try Again!";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

    }
}
