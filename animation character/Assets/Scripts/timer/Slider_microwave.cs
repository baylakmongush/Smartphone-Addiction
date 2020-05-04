using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_microwave : MonoBehaviour
{
    public Slider mySlider;
    Animator anim;
    public Image items;
    public Image icon;
    public bool animat = false;
    public bool bottle = false;

    public int timeLeft = 5;
    private float gameTime;

    void Start()
    {
        anim = GetComponent<Animator>();
        items = icon;
    }

    // Update is called once per frame
    void Update()
    {
        if (animat)
        {
            mySlider.value = timeLeft;
            gameTime += 1 * Time.deltaTime;
            if (gameTime >= 1)
            {
                timeLeft -= 1;
                gameTime = 0;
            }
        }
        if (timeLeft <= 0)
        {
            anim.SetBool("turn", false);
            bottle = true;
            timeLeft = 5;
        }
    }

    void OnMouseDown()
    {
        if (items.sprite != null)
        {
            anim.SetBool("turn", true);
            animat = true;
        }
    }
}
