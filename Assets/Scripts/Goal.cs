using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private AnalyticsScript analyticsScript;
    [SerializeField] public Text winText;
    [SerializeField] public PlayerControl playerControl; // Reference to the player's control script
    [SerializeField] public ClonePlayerManager clonePlayerManager;
    private void Start()
    {
        winText.enabled = false; // Hide the text at the start
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            winText.enabled = true; // Show the text when player collides
            if (SceneManager.GetActiveScene().name == "Tutorial")
            {
                SceneManager.LoadScene("Level 1");
            }
            if (SceneManager.GetActiveScene().name == "Level 1")
            {
                SceneManager.LoadScene("Level 2");
            }
            if (SceneManager.GetActiveScene().name == "Level 2")
            {
                SceneManager.LoadScene("Level 3");
            }
            if (SceneManager.GetActiveScene().name == "Level 3")
            {
                Time.timeScale = 0;
            }
        }

        if(collision.tag == "Clone")
        {
            winText.enabled = true; // Show the text when player collides
            if (SceneManager.GetActiveScene().name == "Tutorial")
            {
                SceneManager.LoadScene("Level 1");
            }
            if (SceneManager.GetActiveScene().name == "Level 1")
            {
                SceneManager.LoadScene("Level 2");
            }
            if (SceneManager.GetActiveScene().name == "Level 2")
            {
                SceneManager.LoadScene("Level 3");
            }
            if (SceneManager.GetActiveScene().name == "Level 3")
            {
                Time.timeScale = 0;
            }
        }
        
        if(collision.tag == "Player")
        {
            int currentLevel = LevelManager.Instance.CurrentLevelNumber;
            Debug.Log(currentLevel);
            string playerId = FindObjectOfType<PlayerID>().ID; // Obtain the player ID.
            analyticsScript = GameObject.FindGameObjectWithTag("TagA").GetComponent<AnalyticsScript>();
            analyticsScript.TrackLevelCompletion(playerId,currentLevel);

        }

        if(collision.tag == "Clone")
        {
            int currentLevel = LevelManager.Instance.CurrentLevelNumber;
            Debug.Log(currentLevel);
            string playerId = FindObjectOfType<PlayerID>().ID; // Obtain the player ID.
            analyticsScript = GameObject.FindGameObjectWithTag("TagA").GetComponent<AnalyticsScript>();
            analyticsScript.TrackLevelCompletion(playerId,currentLevel);

        }
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Goal : MonoBehaviour
// {
//     private void OnTriggerEnter2D(Collider2D collision)
//     {

//         if(collision.tag == "Player")
//         {
//             Debug.Log("You win!");
//         }
//     }
// }