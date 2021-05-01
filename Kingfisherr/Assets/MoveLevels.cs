using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveLevels : MonoBehaviour
{
    public GameObject winScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "Finish")
        {
            winScreen.SetActive(true);
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
