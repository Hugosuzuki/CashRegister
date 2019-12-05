using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class AddScoreTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        Score.ChangeScore(50);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
