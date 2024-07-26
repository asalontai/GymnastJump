using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollider : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
         if (rb != null)
         {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();  
            rb.angularVelocity = 0;
         }
    }
}
