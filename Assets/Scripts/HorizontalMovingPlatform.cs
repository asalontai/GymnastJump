using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovingPlatform : MonoBehaviour
{
    private bool isMovingLeft = false;
    public int speed;
    public int hitsNeeded = 1;
    public int hitsTaken;

    void Update()
    {

        if (isMovingLeft)
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime,
                transform.position.y, transform.position.z);

            if (transform.position.x <= -40)
            {
                isMovingLeft = false;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime,
                transform.position.y, transform.position.z);

            if (transform.position.x >= 40)
            {
                isMovingLeft = true;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        hitsTaken += 1;
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.pitch =  Random.Range(0.8f, 1.5f);
        audioSource.Play();

        if(hitsTaken >= hitsNeeded)
        {
            Destroy(gameObject);
        }
    }
}
