using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GG : MonoBehaviour
{
    Vector2 position;
    float movespeed = 10f;
    private void moveborders()
    {
        Camera gamecamera = Camera.main;
        xmin = gamecamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        ymin = gamecamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        xmax = gamecamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        ymax = gamecamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
    }
    // Start is called before the first frame update
    void Start()
    {
        moveborders();
    }

    float input;
    float ymin, xmin, xmax, ymax;
    // Update is called once per frame

    private void move()
    {
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, xmin, xmax);
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        var newPosY = Mathf.Clamp(transform.position.y + deltaY, ymin, ymax);
        transform.position = new Vector2(newPosX, newPosY);
    }

    void Update()
    {
        move();
    }

    
}
