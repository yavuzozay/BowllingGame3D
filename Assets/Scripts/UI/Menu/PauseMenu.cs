using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused ;
    public GameObject pauseMenuUI;

    private void Awake()
    {
        GameIsPaused = false;
        pauseMenuUI.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            Resume();
        else
                Pause();
        }
            
    }
     void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;

        GameIsPaused = false;

    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true; 
    }
   public void GoToMainMenu()
    {
        Loader.Load(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
