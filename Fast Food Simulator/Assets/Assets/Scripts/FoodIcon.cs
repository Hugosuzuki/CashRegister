using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FoodIcon : MonoBehaviour
{
    [SerializeField]
    public Object Prefab;

    GameObject[] Ingredients;

    private Vector2 initPos;
    private Vector2 mousePos;
    private float dX, dY;
    GameObject temp;

    // Start is called before the first frame update
    void Start()
    {
        // Save first position
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
        Instantiate(Prefab, new Vector3(mousePos.x, mousePos.y, 0.0f), Quaternion.identity);
        transform.position = initPos;
        Ingredients[Ingredients.Length] = temp;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
