using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egg : MonoBehaviour
{
    [SerializeField]
    private Transform table;

    private Vector2 initPos;

    private Vector2 mousePos;

    private float dX, dY;

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


    // Set position of object to proper location
    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - table.position.x) <= 0.5f && Mathf.Abs(transform.position.y - table.position.y) <= 0.5f)
        {
            transform.position = new Vector2(table.position.x, table.position.y);
        }
        else
        {
            transform.position = new Vector2(initPos.x, initPos.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
