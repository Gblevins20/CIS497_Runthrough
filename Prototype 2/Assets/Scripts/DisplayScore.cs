/*
 * Gregory Blevins
 * Prototype 2
 * Displays feedback to player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text textBox;

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        textBox = GetComponent<Text>();
        textBox.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text = "Score: " + score;
    }
}
