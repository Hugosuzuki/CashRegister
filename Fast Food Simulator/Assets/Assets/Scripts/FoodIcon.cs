﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodIcon : MonoBehaviour
{
    [SerializeField]
    public Object Prefab;

    [SerializeField]
    public GameObject slot;

    private void OnMouseUpAsButton()
    {
        Instantiate(Prefab, slot.transform.position, Quaternion.identity);
        Debug.Log("fuckme");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}