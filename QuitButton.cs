using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    public void QGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
