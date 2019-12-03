using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    private static float totalTime;
    public static float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeLeft -= Time.fixedDeltaTime;
    }

    public static void StartRound()
    {
        timeLeft = totalTime = 420f;
    }
}
