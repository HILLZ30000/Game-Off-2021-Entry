using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseM;
    public static bool isPaused;
    public GameObject Screen1, Screen2, Screen3;

    private void Start()
    {
        Time.timeScale = 1;
        PauseM.SetActive(false);
        isPaused = false;
        Spawn.SpawnValue = 15;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            Time.timeScale = 0;
            Spawn.SpawnValue = 0;
            Screen1.SetActive(false);
            Screen2.SetActive(false);
            Screen3.SetActive(false);
            PauseM.SetActive(true);
            isPaused = true;

        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true)
        {
            Time.timeScale = 1;
            Spawn.SpawnValue = 15;
            Screen1.SetActive(true);
            Screen2.SetActive(true);
            Screen3.SetActive(true);
            PauseM.SetActive(false);
            isPaused = false;
        }


    }



}
