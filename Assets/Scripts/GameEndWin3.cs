using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndWin3 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("BOOM " + col.gameObject.tag);
        if(col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(7);
        }
    }
}
