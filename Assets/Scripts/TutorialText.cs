using UnityEngine;
using TMPro; // Uncomment if using TextMeshPro

public class PlatformTrigger : MonoBehaviour
{
    public TMP_Text hintText; // Uncomment if using TextMeshPro

    void Start()
    {
        hintText.enabled = false; // Hide the text initially
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Assuming your player has a tag "Player"
        {
            hintText.enabled = true; // Show the text
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hintText.enabled = false; // Hide the text
        }
    }
}
