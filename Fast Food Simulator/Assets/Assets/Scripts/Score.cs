using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    static int playerScore;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 1000;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public static void ChangeScore(int scoreVal)
    {
        playerScore += scoreVal;
    }
}
