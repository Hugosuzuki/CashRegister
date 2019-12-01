using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garbage: MonoBehaviour
{
    GameObject[] Ingredients;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseUp()
    {
        Ingredients = GameObject.FindGameObjectsWithTag("Ingredient");

        for (var i = 0; i < Ingredients.Length; i++)
            Destroy(Ingredients[i]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
