using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public ChangeScene cs;

    public GameObject PMUI; //pause menu ui

    public static bool IsGamePaused = false;  

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsGamePaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }

       else if(Input.GetKeyDown("m") &&  IsGamePaused)
        {
            cs.MoveToScene(0);
        }

        else if (Input.GetKeyDown("r") && IsGamePaused)
        {
            cs.MoveToScene(8);
            Resume();
        }
    }


    void Resume()
    {
        PMUI.SetActive(false);
        Time.timeScale = 1;
        IsGamePaused = false;
    }

    void Pause()
    {
        PMUI.SetActive(true);
        Time.timeScale = 0;
        IsGamePaused = true;
    }
}