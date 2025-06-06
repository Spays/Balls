using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTranslate : MonoBehaviour
{
    public float speed = 4f;
    private Vector2 pointScreen;
    private Vector2 offset;

    
    void OnMouseDown()
    {
        pointScreen = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));

        
    }
    void OnMouseDrag()
    {
        Vector2 curPosition = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        transform.position = curPosition;

        if (Input.GetMouseButton(1))
        {
            

            Vector2 mousePos = Input.mousePosition;
            if (Input.GetKey(KeyCode.LeftShift))
                transform.RotateAround(new Vector3(0, 0, 1), -speed * Time.deltaTime);
            else transform.RotateAround(new Vector3(0, 0, 1), speed * Time.deltaTime);
        }
    }

    
}
