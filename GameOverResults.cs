using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverResults : MonoBehaviour
{
    public int GameOverHighScore = MenuScore.HighScore;
    public int EndScore = ScoreSystem.Score;
    public Text FinalScore;
    public Text feedback;

    private void Update()
    {
        EndScore += GameOverHighScore;
        FinalScore.text = EndScore.ToString();

        if (EndScore >= GameOverHighScore)
        {
            feedback.text = "MAMA!";
        
        }


    }
}
