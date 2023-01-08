using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private AudioSource scoreSoundEffect, dieSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Apple"))
        {
            Destroy(collision.gameObject);
            scoreSoundEffect.Play();
        }

        else if(collision.CompareTag("Obstacle"))
        {
            Time.timeScale = 0;
            dieSoundEffect.Play();
        }
    }
}
