/*
 * Gregory Blevins
 * Prototype 5
 * Handle Difficulty Tweaking
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;

    private GameManager difficultySelector;

    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(SetDifficulty);

        difficultySelector = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    void SetDifficulty()
    {
        difficultySelector.StartGame(difficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
