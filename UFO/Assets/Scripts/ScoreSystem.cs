using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public int score = 0; //Score
    public int highScore = 0; //High Score
    string highScoreKey = "HighScore"; //string key use to help save the high score

    public TextMeshPro scoreText; //Text use to display Score
    public TextMeshPro highScoreText; //Text use to display the High Score

    // Start is called before the first frame update
    void Start()
    {
        //At the start, we have the high score set to the current high score while also setting score to 0
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Set the text for both scoreText and highScoreText to their respective scores
        scoreText.text = score.ToString();
        highScoreText.text = "Best:\n" + highScore.ToString();
        
        //If the score is greater than our current high score, we set the high score equal to the score
        //Set the player preference to our highScoreKey and current score and then save it to PlayerPrefs
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt(highScoreKey, score);
            PlayerPrefs.Save();
        }
    }
}
