using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InclineBlock : MonoBehaviour
{
    public float jumpForce = 75f; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.pitch =  Random.Range(0.8f, 1.5f);
        audioSource.Play();  
        if(collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
        }
    }
}
