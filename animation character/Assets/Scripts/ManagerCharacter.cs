using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ManagerCharacter : MonoBehaviour
{
    public float speed = 1;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //Walking character
        float input = Input.GetAxis("Horizontal");
        float input_vert = Input.GetAxis("Vertical");
        Vector2 scale = transform.localScale;
        Vector2 movement_vector = transform.position;
        if (input > 0)
        {
            anim.SetBool("direction", true);
            anim.SetBool("walk", true);
            movement_vector.x += Time.deltaTime * input * 2;
            transform.position = movement_vector;
        }
        else if (input < 0)
        {
            anim.SetBool("direction", false);
            anim.SetBool("walk", true);
            movement_vector.x += Time.deltaTime * input * 2;
            transform.position = movement_vector;
        }
        else if (input_vert > 0 )
        {
            scale.x -= 0.01f;
            scale.y -= 0.01f;
            movement_vector.y += Time.deltaTime * input_vert * .05f;
            anim.SetBool("walk", true);
            transform.localScale = scale;
            transform.position = movement_vector;
        }
        else if (input_vert < 0)
        {
            scale.x += 0.01f;
            scale.y += 0.01f;
            movement_vector.y += Time.deltaTime * input_vert * .05f;
            anim.SetBool("walk", true);
            transform.localScale = scale;
            transform.position = movement_vector;
        }
        else
            anim.SetBool("walk", false);
    }
}