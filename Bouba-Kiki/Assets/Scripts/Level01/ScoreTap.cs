using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTap : MonoBehaviour
{
    TextMeshProUGUI scoreDisplay;
    public int i_score = 0;

    private void OnEnable()
    {
        TouchEvent.OnCorrectShape += ChangeScore;
    }
    private void OnDisable()
    {
        TouchEvent.OnCorrectShape -= ChangeScore;
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
