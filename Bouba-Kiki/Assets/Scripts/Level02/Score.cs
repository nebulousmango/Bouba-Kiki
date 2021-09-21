using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    TextMeshProUGUI scoreDisplay;

    void Start()
    {
        TextMeshProUGUI scoreDisplay = GetComponent<TextMeshProUGUI>();
    }

    public void ChangeText(string text)
    {
        TextMeshProUGUI scoreDisplay = GetComponent<TextMeshProUGUI>();
        scoreDisplay.text = text;
    }
}
