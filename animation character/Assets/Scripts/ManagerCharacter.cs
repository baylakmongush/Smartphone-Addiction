using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ManagerCharacter : MonoBehaviour
{
    public float speed = 1;
    Animator anim;
    float input;
    float input_vert;
    public GameObject phone;
    Vector3 position;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //Walking character
        input = Input.GetAxis("Horizontal");
        input_vert = Input.GetAxis("Vertical");
        Vector2 scale = transform.localScale;
        position = transform.position;
        Vector2 movement_vector = transform.position;
        if (input > 0 && transform.position.x < 3.91f)
        {
            anim.SetBool("direction", true);
            anim.SetBool("walk", true);
            movement_vector.x += Time.deltaTime * input * 2;
            transform.position = movement_vector;
            if (transform.position.x < -0.23f && transform.position.x > -2)
            {
                position.x = -0.1f;
                transform.position = position;
            }
            if (transform.position.x < -8.82f && transform.position.x > -10.66)
            {
                position.x = -8.82f;
                transform.position = position;
            }
        }
        else if (input < 0 && transform.position.x > -14.02f)
        {
            anim.SetBool("direction", false);
            anim.SetBool("walk", true);
            movement_vector.x += Time.deltaTime * input * 2;
            transform.position = movement_vector;
            if (transform.position.x < -0.23f && transform.position.x > -2)
            {
                position.x = -2;
                transform.position = position;
            }
            if (transform.position.x < -8.82f && transform.position.x > -10.66)
            {
                position.x = -10.66f;
                transform.position = position;
            }
        }
        else
            anim.SetBool("walk", false);
        if (input == 0 && input_vert == 0)
            phone.transform.position = Vector3.Lerp(phone.transform.position, new Vector3(phone.transform.position.x, Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, 0, 0)).y * 0.9f, 0), 2 * Time.deltaTime);
        else
            phone.transform.position = Vector3.Lerp(phone.transform.position, new Vector3(phone.transform.position.x, Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, 0, 0)).y * 1.4f, 0), 2 * Time.deltaTime);
    }
}