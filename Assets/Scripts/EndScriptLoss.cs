using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndScriptLoss : MonoBehaviour
{
    Text ScoreText;
    public static int Convert;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        Convert = ScoreBoard.Score;
        ScoreText.text = "You got a score of " + Convert.ToString();
    }
}
