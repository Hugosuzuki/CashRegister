using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public static float TIME;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TIME += Time.fixedDeltaTime;
    }

    public static void NextSandwich()
    {
        TIME = 0;
    }
}
