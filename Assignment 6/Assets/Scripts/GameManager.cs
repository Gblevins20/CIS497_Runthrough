/*
 * Gregory Blevins
 * Assignment 6
 * Handles Level Loading and Score Tracking
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public int score;
    public int health;

    private bool GameLoss;
    private bool GameWin;

    public bool GameFinish;

    //Variable to Track Currently Loaded Level
    private string CurrentLevelName = string.Empty;


    protected override void Awake()
    {
        base.Awake();
        CurrentLevelName = SceneManager.GetActiveScene().name;

        score = 0;
        health = 3;

        GameLoss = GameWin = GameFinish = false;
    }

    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);

        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to load level " + levelName);
            return;
        }
        CurrentLevelName = levelName;
    }

    public void UnloadCurrentLevel()
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);

        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to unload level " + CurrentLevelName);
            return;
        }
    }

    public string GetCurrentLevelName()
    {
        return CurrentLevelName;
    }

    void GameOver()
    {
        if (health <= 0)
        {
            GameLoss = true;
        }
        else if (score >= 10)
        {
            GameWin = true;
        }
    }

}
