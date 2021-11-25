using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScore : MonoBehaviour
{
    public Text score;
    static public int HighScore;
    void Update()
    {
        HighScore = PlayerPrefs.GetInt("HighScore");
        score.text = HighScore.ToString();

    }
}
