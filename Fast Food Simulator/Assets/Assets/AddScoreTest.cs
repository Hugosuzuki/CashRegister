using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseUp()
    {
        Score.ChangeScore(50);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
