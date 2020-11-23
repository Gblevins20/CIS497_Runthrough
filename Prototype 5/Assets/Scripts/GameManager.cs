/*
 * Gregory Blevins
 * Prototype 5
 * Manages Game States and spawns
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;

    public Button restartButton;

    private float spawnRate = 1.0f;

    private int score;

    public bool isGameActive;

    public GameObject titleScreen;

    public void StartGame(int difficulty)
    {
        isGameActive = true;

        spawnRate /=  difficulty;

        StartCoroutine(SpawnTarget());

        score = 0;

        UpdateScore(0);

        titleScreen.gameObject.SetActive(false);
    }

    IEnumerator SpawnTarget()
    {

        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);

            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);


            //UpdateScore(5);
        }

    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);

        restartButton.gameObject.SetActive(true);

        isGameActive = false;
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;

        scoreText.text = "Score: " + score;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
