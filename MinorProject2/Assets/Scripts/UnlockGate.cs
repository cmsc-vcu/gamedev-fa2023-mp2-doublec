using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockGate : MonoBehaviour
{
    public GameObject Gate;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(Gate);
        }
    }
}
