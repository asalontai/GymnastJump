using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Col3Platform : MonoBehaviour
{
    public int hitsNeeded = 3;
    public int hitsTaken;

    void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.pitch =  Random.Range(0.8f, 1.5f);
        audioSource.Play(); 
        hitsTaken += 1;

        if(hitsTaken >= hitsNeeded)
        {
 
            Destroy(gameObject);
        }
    }
}
