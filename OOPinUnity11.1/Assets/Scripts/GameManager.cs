/*
 * Gregory Blevins
 * Assignment 6
 * Handles Game Systems
*/
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public int score;

    public GameObject pauseMenu;

    //Variable to Track Currently Loaded Level
    private string CurrentLevelName = string.Empty;


    protected override void Awake()
    {
        base.Awake();
        CurrentLevelName = SceneManager.GetActiveScene().name;
    }

    //#region This code makes this class a Singleton
    //public static GameManager instance;

    //private void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //        Debug.Log("Trying to instantiate a second " + "instance of singleton Game Manager");
    //    }
    //}
    //#endregion

    //Methods to change scenes
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

    public void UnLoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);

        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to unload level " + levelName);
            return;
        }
        CurrentLevelName = levelName;
    }

    //Pause and Unpause

    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void UnPause()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }

}
