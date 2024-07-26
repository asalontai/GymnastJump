using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public static int Score = 0;

    void OnGUI()
    {
        GUI.Box(new Rect(50,200,100,100),"Score: " + Score.ToString());
    }
}
