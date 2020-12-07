using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;
    public GameObject victory;

    private void Update()
    {
        scoreDisplay.text = score.ToString();

        if (score >= 40)
        {
            victory.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //increase score every time obstacles collides with scoremanager object at left once clears camera
        if (other.CompareTag("Obstacle"))
        {
            score++;
            Debug.Log(score);
        }
    }
}
