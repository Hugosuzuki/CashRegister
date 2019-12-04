using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    static int playerScore;

    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 1000;

        scoreText = GetComponent<Text>();

        scoreText.font = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerScore >= 1200)
        {
            scoreText.color = Color.green;
        }
        else if(playerScore >= 800)
        {
            scoreText.color = new Color(1f, 1f, 0f);
        }
        else
        {
            scoreText.color = Color.red;
        }

        scoreText.text = "" + playerScore;
    }

    public static void ChangeScore(int scoreVal)
    {
        playerScore += scoreVal;
    }
}
