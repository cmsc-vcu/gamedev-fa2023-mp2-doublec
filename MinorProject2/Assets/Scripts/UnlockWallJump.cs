using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockWallJump : MonoBehaviour
{
    bool used;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerMovement2.unlockedWallJump)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D _collision)
    {
        if(_collision.CompareTag("Player") && !used)
        {
            used = true;
            PlayerMovement2.unlockedWallJump = true;

            Destroy(gameObject);

        }
    }
}
