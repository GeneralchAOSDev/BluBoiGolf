using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    static public float score = 0f;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Strokes: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Strokes: " + score;
    }

    public static void UpdateScore()
    {
        score++;
    }
}
