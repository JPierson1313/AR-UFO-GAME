using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;
    string highScoreKey = "HighScore";

    public TextMeshPro scoreText;
    public TextMeshPro highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        highScoreText.text = "Best:\n" + highScore.ToString();
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt(highScoreKey, score);
            PlayerPrefs.Save();
        }
    }
}
