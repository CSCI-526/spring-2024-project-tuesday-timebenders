using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{

    public void GoToLevel1()
    {
        SceneManager.LoadScene("Level 1");
        Time.timeScale = 1f; // Resume the game
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene("Level 2");
        Time.timeScale = 1f; // Resume the game
    }
    
    public void GoToLevel3()
    {
        SceneManager.LoadScene("Level 3");
        Time.timeScale = 1f; // Resume the game
    }

    public void GoToLevel4()
    {
        SceneManager.LoadScene("Level 4");
        Time.timeScale = 1f; // Resume the game
    }

}