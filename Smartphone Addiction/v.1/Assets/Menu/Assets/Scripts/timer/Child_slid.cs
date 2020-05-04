using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Child_slid : MonoBehaviour
{
    public Slider mySlider;
    Animator anim;
    public Image items;
    public Image icon;
    public bool child = false;
    public Slider_microwave micro;

    public int timeLeft = 15;
    private float gameTime;

    void Start()
    {
        anim = GetComponent<Animator>();
        items = icon;
    }

    // Update is called once per frame
    void Update()
    {
        if (child)
        {
            mySlider.value = timeLeft;
            gameTime += 1 * Time.deltaTime;
            if (gameTime >= 1)
            {
                if (timeLeft > 0)
                    timeLeft -= 1;
                gameTime = 0;
            }
        }
        if (timeLeft <= 0)
        {
            anim.SetBool("child_cry", true);
            child = false;
        }
    }

    void OnMouseDown()
    {
        Debug.Log("a");
        if (items.sprite != null)
        {
            anim.SetBool("child_milk", true);
            child = true;
        }
    }
}

