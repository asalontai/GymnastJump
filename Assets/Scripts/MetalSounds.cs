using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalSounds : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.pitch =  Random.Range(0.8f, 1.5f);
        audioSource.Play(); 
        
    }

}
