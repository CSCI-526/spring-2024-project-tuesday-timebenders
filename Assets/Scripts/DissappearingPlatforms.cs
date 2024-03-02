using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatforms : MonoBehaviour
{
    public SpriteRenderer buttonRenderer;
    public Color activeColor;
    public Color inactiveColor;
    public GameObject Platform;

    private bool isWeightOnButton = false;
    private int playerCount = 0;

private void Update()
{
    if (isWeightOnButton)
    {
        buttonRenderer.transform.localScale = Vector3.one * 1.1f; // Slightly larger
        CloseDoor();
    }
    else
    {
        buttonRenderer.transform.localScale = Vector3.one; // Normal size
        OpenDoor();
    }
}

// For Rotation instead of Scale Change
// private void Update()
// {
//     if (isWeightOnButton)
//     {
//         buttonRenderer.transform.rotation = Quaternion.Euler(0, 0, 15); // Rotate 15 degrees
//         CloseDoor();
//     }
//     else
//     {
//         buttonRenderer.transform.rotation = Quaternion.identity; // No rotation
//         OpenDoor();
//     }
// }

// For Opacity Change instead of Scale Change
// private void Update()
// {
//     if (isWeightOnButton)
//     {
//         buttonRenderer.color = new Color(buttonRenderer.color.r, buttonRenderer.color.g, buttonRenderer.color.b, 1f); // Fully opaque
//         CloseDoor();
//     }
//     else
//     {
//         buttonRenderer.color = new Color(buttonRenderer.color.r, buttonRenderer.color.g, buttonRenderer.color.b, 0.5f); // Semi-transparent
//         OpenDoor();
//     }
// }


    private void OpenDoor()
    {
        // Open the door (e.g., by rotating it or moving it up)
        Platform.SetActive(false);
    }
    private void CloseDoor()
    {
        // Close the door (e.g., by rotating it back or moving it down)
        Platform.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerCount++;
            isWeightOnButton = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerCount--;
            if (playerCount == 0)
            {
                isWeightOnButton = false;
            }
        }
    }
}