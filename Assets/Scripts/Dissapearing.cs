using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapearing : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject platform;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.pitch =  Random.Range(0.8f, 1.5f);
        audioSource.Play();
    }
    void Start()
    {
        Invoke("Show",2f);
    }

    void Show()
    {
        platform.SetActive(true);
        Invoke("Hide",2f);
    }

    void Hide()
    {
        platform.SetActive(false); 
        Invoke("Show",2f);
    }
}

