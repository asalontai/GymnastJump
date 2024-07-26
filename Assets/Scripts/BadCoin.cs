using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCoin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.pitch =  Random.Range(0.8f, 1.5f);
            audioSource.Play();  
            Debug.Log("15 points");
            ScoreBoard.Score -= 15;
            Destroy(gameObject);
        }
    }
}
