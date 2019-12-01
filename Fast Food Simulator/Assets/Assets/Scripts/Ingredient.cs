using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    private Vector2 initPos; // Object's initial position 
    private Vector2 mousePos;
    private float dX, dY; // Difference between click location and object position

    [SerializeField]
    public bool isBread;
    public bool toasted;

    // Start is called before the first frame update
    void Start()
    {
        initPos = transform.position;
        
    }

    // Calculate the difference between click location and object position
    private void OnMouseDown()
    {
        dX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        dY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
    }

    // Calculate position of object and mouse with screen to world position
    private void OnMouseDrag()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePos.x - dX, mousePos.y - dY);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
