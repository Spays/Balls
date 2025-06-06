using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTranslate : MonoBehaviour
{
    public float speed = 4f;
    private Vector2 pointScreen;
    private Vector2 offset;

    /*
    void Update()
    {
        if (Input.GetMouseButton(0))  // Зажмите левую кнопку мыши
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);  // Переводим экранные координаты в мировые
            transform.position = Vector2.Lerp(transform.position, mousePos, speed * Time.deltaTime);  // Плавное перемещение
        }
        if (Input.GetMouseButton(0) && Input.GetButtonDown("r"))
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime, 0);
        }
    }
    */
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
            //transform.Rotate(0, 0, Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime);

            Vector2 mousePos = Input.mousePosition;//Camera.main.ScreenToWorldPoint(Input.mousePosition);  // Переводим экранные координаты в мировые
            //transform.Rotate(Vector2.Lerp(transform.position, mousePos, speed * Time.deltaTime));  // Плавное перемещение
            if (Input.GetKey(KeyCode.LeftShift))
                transform.RotateAround(new Vector3(0, 0, 1), -speed * Time.deltaTime);
            else transform.RotateAround(new Vector3(0, 0, 1), speed * Time.deltaTime);
        }
    }

    /*
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            //transform.Rotate(0, 0, Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime);

            Vector2 mousePos = Input.mousePosition;//Camera.main.ScreenToWorldPoint(Input.mousePosition);  // Переводим экранные координаты в мировые
            //transform.Rotate(Vector2.Lerp(transform.position, mousePos, speed * Time.deltaTime));  // Плавное перемещение
            transform.RotateAround(new Vector3(0,0,1), speed * Time.deltaTime);
        }
    }
    */
}
