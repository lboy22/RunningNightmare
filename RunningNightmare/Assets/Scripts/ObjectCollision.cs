using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Apple"))
        {
            Destroy(collision.gameObject);
        }

        else if (collision.CompareTag("Obstacle"))
        {
            Destroy(collision.gameObject);
        }
        
    }
}
