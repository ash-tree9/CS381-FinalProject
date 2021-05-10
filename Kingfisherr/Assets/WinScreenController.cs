using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenController : MonoBehaviour
{
    public GameObject winScreen;
    public void MainMenu()
    {
  
      
        pickupFish.scoreValue = 0;
        SceneManager.LoadScene("MainMenu");
    }
}
