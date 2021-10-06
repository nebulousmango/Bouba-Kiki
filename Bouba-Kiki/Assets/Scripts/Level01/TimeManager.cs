using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    float timeRemaining = 60;
    bool timerIsRunning = false;
    int finalScore;
    [SerializeField] GameObject levelOverUI;
    [SerializeField] GameObject scoreUI;
    [SerializeField] TextMeshProUGUI finalScoreDisplay;

    private void Start()
    {
        timerIsRunning = true;
        levelOverUI.SetActive(false);
        TextMeshProUGUI finalScoreDisplay = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                LevelOver();
            }
        }
    }

    public void LevelOver()
    {
        levelOverUI.SetActive(true);
        scoreUI.GetComponent<TextMeshProUGUI>().enabled = false;
        FindObjectOfType<EndlessLevel>().DisableScripts();
        finalScore = FindObjectOfType<ScoreTap>().i_score;
        finalScoreDisplay.text = finalScore.ToString();
    }
}
