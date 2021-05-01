using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject instructionsMenu;
    public GameObject creditsMenu;

    public void playGame()
    {
        SceneManager.LoadScene("LevelOneScene");
    }

    public void instructions()
    {
        mainMenu.SetActive(false);
        instructionsMenu.SetActive(true);
    }

    public void credits()
    {
        mainMenu.SetActive(false);
        creditsMenu.SetActive(true);
    }

    public void back()
    {
        mainMenu.SetActive(true);
        instructionsMenu.SetActive(false);
        creditsMenu.SetActive(false);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
