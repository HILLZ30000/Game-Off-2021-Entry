using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedBack : MonoBehaviour
{
    public Text FeedbackText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreSystem.Score > PlayerPrefs.GetInt("HighScore"))
        {
            FeedbackText.text = "Awesome! That is a new score! Well done!";
        }
        else if (ScoreSystem.Score < PlayerPrefs.GetInt("HighScore"))
        {
            FeedbackText.text = "Try again to beat the high score!";
        }
        else if (ScoreSystem.Score == PlayerPrefs.GetInt("HighScore"))
        {
            FeedbackText.text = "You are so close to getting a new high score! Try again!";
        }

    }
}
