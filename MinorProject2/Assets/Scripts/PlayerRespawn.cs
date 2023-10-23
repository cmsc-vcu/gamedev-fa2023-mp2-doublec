using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public string respawnPointTag = "RespawnPoint"; // Tag of the respawn point GameObject.

    private Transform respawnPoint; // The transform of the respawn point.

    private void Start()
    {
        // Find the respawn point by its tag.
        respawnPoint = GameObject.FindGameObjectWithTag(respawnPointTag).transform;

        if (respawnPoint == null)
        {
            Debug.LogError("Respawn point with tag '" + respawnPointTag + "' not found.");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player has touched the designated GameObject.
        if (other.CompareTag("YourDesignatedObjectTag"))
        {
            // Respawn the player at the designated respawn point.
            RespawnPlayer();
        }
    }

    private void RespawnPlayer()
    {
        if (respawnPoint != null)
        {
            // Move the player to the respawn point.
            transform.position = respawnPoint.position;
        }
        else
        {
            Debug.LogError("Respawn point not set.");
        }
    }
}
