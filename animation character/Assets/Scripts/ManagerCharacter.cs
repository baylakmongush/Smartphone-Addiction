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

        float input = Input.GetAxis("Horizontal");
        Vector2 movement_vector = transform.position;
        if (input > 0)
        {
            anim.SetBool("direction", true);
            anim.SetBool("walk", true);
            movement_vector.x += Time.deltaTime * input * 5;
            transform.position = movement_vector;
        }
        else if (input < 0)
        {
            anim.SetBool("direction", false);
            anim.SetBool("walk", true);
            movement_vector.x += Time.deltaTime * input;
            transform.position = movement_vector;
        }
        else
            anim.SetBool("walk", false);
    }
}