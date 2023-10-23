using System.Collections;
using UnityEngine;

public class FallingPlatformRespawn : MonoBehaviour
{
    public float respawnDelay = 5f; // Adjust the delay as needed.

    private FallingPlatform fallingPlatform;
    private Vector2 originalPosition;

    private void Start()
    {
        fallingPlatform = GetComponent<FallingPlatform>();
        originalPosition = fallingPlatform.transform.position;

        // Start the respawn process immediately (if needed).
        StartCoroutine(RespawnPlatform());
    }

    private IEnumerator RespawnPlatform()
    {
        // Wait for the specified respawn delay.
        yield return new WaitForSeconds(respawnDelay);

        // Reset the platform's position and Rigidbody using the property.
        fallingPlatform.Rigidbody.bodyType = RigidbodyType2D.Static;
        fallingPlatform.transform.position = originalPosition;

        // Start listening for collisions again.
        fallingPlatform.enabled = true;
    }
}
