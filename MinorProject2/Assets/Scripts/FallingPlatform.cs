using System.Collections;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private float fallDelay = 0f;
    private float destroyDelay = 10f;

    [SerializeField] private Rigidbody2D rb;
    private Vector2 originalPosition; // Store the original position.

    public Rigidbody2D Rigidbody // Public property to access the Rigidbody.
    {
        get { return rb; }
    }

    private void Start()
    {
        // Store the original position at the start.
        originalPosition = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }
    }

    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        yield return new WaitForSeconds(destroyDelay);

        // Reset the platform's position and Rigidbody.
        rb.bodyType = RigidbodyType2D.Static;
        transform.position = originalPosition;
    }
}
