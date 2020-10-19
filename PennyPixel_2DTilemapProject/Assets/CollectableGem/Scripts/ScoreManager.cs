/*
 * Gregory Blevins
 * Penny Pixel Modifications
 * Controls Scoring System
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int score;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        scoreText.text = "Score = 0";
    }


    public void increaseScore()
    {
        score++;

        scoreText.text = "Score = " + score;
    }
}
