using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SandwichTimer : MonoBehaviour
{
    float currentTime;

    static int scoreValue;

    Text timeField;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 42f;

        timeField = GetComponent<Text>();

        timeField.font = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentTime -= Time.fixedDeltaTime;

        if(currentTime >= 21)
        {
            scoreValue = 200;
            timeField.color = Color.green;
        }
        else if(currentTime >= 0)
        {
            scoreValue = 100;
            timeField.color = Color.yellow;
        }
        else
        {
            scoreValue = 0;
            timeField.color = Color.red;
        }

        timeField.text = "Time: " + (int)(GameTimer.TIME);
    }

    public static void FinishedSandwich(int mult = 1)
    {
        Score.ChangeScore(scoreValue * mult);
    }

    private void OnDestroy()
    {
        FinishedSandwich();
    }
}
