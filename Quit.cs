using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void End()
    {
        
        

        if (ScoreSystem.Score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", ScoreSystem.Score);
        }

        SceneManager.LoadScene("MainMenu");

    }
}
