using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    TextMeshProUGUI scoreDisplay;
    public int i_score = 0;

    private void OnEnable()
    {
        EventManager.OnObjectFall += ChangeScore;
    }

    private void OnDisable()
    {
        EventManager.OnObjectFall -= ChangeScore;
    }

    void ChangeScore()
    {
        i_score++;
        ChangeText("Score: " + i_score);
    }

    void Start()
    {
        TextMeshProUGUI scoreDisplay = GetComponent<TextMeshProUGUI>();
    }

    void ChangeText(string text)
    {
        TextMeshProUGUI scoreDisplay = GetComponent<TextMeshProUGUI>();
        scoreDisplay.text = text;
    }
}
