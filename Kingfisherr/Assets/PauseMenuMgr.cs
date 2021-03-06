using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuMgr : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (gamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        gamePaused = false;
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
        pickupFish.scoreValue = 0;
        SceneManager.LoadScene("MainMenu");
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        gamePaused = true;
        Time.timeScale = 0f;
    }
}
