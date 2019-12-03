using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichTimer : MonoBehaviour
{
    private float sandwichTime;
    private float currentTime;

    int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
        sandwichTime = 42f;
        currentTime = 42f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentTime -= Time.fixedDeltaTime;

        if(currentTime >= 21f)
        {
            scoreValue = 200;
        }
        else if(currentTime > 0f)
        {
            scoreValue = 100;
        }
        else
        {
            scoreValue = 0;
        }
    }

    public void FinishedSandwich()
    {
        //put an if here for if the sanwich is correct, so we can set it to just send through a negative instead of a positive time
        Score.ChangeScore(scoreValue);
    }

    private void OnDestroy()
    {
        FinishedSandwich();
    }
}
