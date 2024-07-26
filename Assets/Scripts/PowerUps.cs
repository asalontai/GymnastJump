using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public GameObject[] Spawning;
    public GameObject Platform;
    public float Timer = 100000000000000000000000000000000f;
    
    

    void Start()
    {
            GameObject RandomPos = Spawning[Random.Range(0, Spawning.Length)];
            RandomPos.transform.position = Platform.transform.position;
            RandomPos.transform.position = new Vector2(RandomPos.transform.position.x,RandomPos.transform.position.y+6f);
            Instantiate(RandomPos);
    }
}
