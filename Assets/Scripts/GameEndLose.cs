using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameEndLose : MonoBehaviour
{
    public float speed;
    
    void Update() {
          transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
     }

    public void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("BOOM " + col.gameObject.tag);
        if(col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }
}
