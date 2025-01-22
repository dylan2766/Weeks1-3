using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public GameObject gameOverScreen;
    public TextMeshProUGUI score;
    int scoreValue = 0;
    bool isPlaying = true;

    private void Start()
    {
        score.text = scoreValue.ToString();
        gameOverScreen.SetActive(false);
    }

    private void Update()
    {
        if (isPlaying == true && Input.GetMouseButtonDown(0))
        {
            scoreValue++;
            score.text = scoreValue.ToString();
        }

        if(scoreValue >= 10)
        {
            gameOverScreen.SetActive(true);
            isPlaying = false;
        }

        if(isPlaying == false && Input.GetKeyDown(KeyCode.Space))
        {
            scoreValue = 0;
            score.text = scoreValue.ToString();
            gameOverScreen.SetActive(false);
            isPlaying = true;
        }
    }
}
