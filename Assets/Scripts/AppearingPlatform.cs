using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearingPlatform : MonoBehaviour
{
    public GameObject platform;

    void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.pitch =  Random.Range(0.8f, 1.5f);
        audioSource.Play();
    }
    void Start()
    {
        Invoke("Hide",2f);
    }

    void Hide()
    {
        platform.SetActive(true);
        Invoke("Show",2f);
    }

    void Show()
    {
        platform.SetActive(false); 
        Invoke("Hide",2f);
    }
}
