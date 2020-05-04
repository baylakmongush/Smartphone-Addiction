using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Charging_slid : MonoBehaviour
{
    public Slider mySlider;
    Animator anim;
    public Image items;
    public Image icon;
    public bool charge = false;
    public bool flag2 = false;

    public int timeLeft = 40;
    private float gameTime;

    void Start()
    {
        anim = GetComponent<Animator>();
        items = icon;
    }

    // Update is called once per frame
    void Update()
    {
        mySlider.value = timeLeft;
        gameTime += 1 * Time.deltaTime;
        if (!(charge))
        {
            if (gameTime >= 1)
            {
                if (timeLeft > 0)
                    timeLeft -= 1;
                gameTime = 0;
            }
        }
        else
        {
            if (gameTime >= 1)
            {
                if (timeLeft < 40)
                    timeLeft += 1;
                else
                {
                    anim.SetBool("charging", false);
                    charge = false;
                }
                gameTime = 0;
            }
        }

        if (timeLeft <= 0)
        {
            flag2 = false;
        }
        else if (timeLeft < 40)
        {
            flag2 = true;
        }
    }

    void OnMouseDown()
    {
        if (items.sprite != null)
        {
            anim.SetBool("charging", true);
            charge = true;
        }
    }
}
