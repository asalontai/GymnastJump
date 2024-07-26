using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinScene4 : MonoBehaviour
{
    public Text scoreText;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        score = ScoreBoard.Score;
    }

    void DisplayHighScore()
    {
        scoreText.text = "You win level 4! You got a score of " + score + "!";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene(10); 
        }
    }
    
}
