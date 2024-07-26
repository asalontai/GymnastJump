using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager8 : MonoBehaviour
{
    public int platfromCount = 200;

    public Vector3 spawnPosition;

    public GameObject[] Platforms;  

    public GameObject[] Positives;
    
    public float Timer = 100000000000000000000000000000000f;   

    void Start()
    {
        spawnPosition = new Vector3();

        for (int i = 0; i < platfromCount; i++)
        {
            GameObject Platform = Platforms[Random.Range(0, Platforms.Length)];
            spawnPosition.y += Random.Range(0.8f, 22f);
            spawnPosition.x = Random.Range(-30f, 30f);
            Instantiate(Platform, spawnPosition, Platform.transform.rotation);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            Destroy(collision.gameObject);
            Debug.Log("Destroy");
        }
    }
}
