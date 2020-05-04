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
    public int add;

    public int timeLeft = 20;
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
            add = -1;
            if (gameTime >= 1)
            {
                if (timeLeft > 0)
                    timeLeft += add;
                gameTime = 0;
            }
        }
        else
        {
            if (gameTime >= 1)
            {
                add = 1;
                if (timeLeft < 18)
                    timeLeft += add;
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
        else if (timeLeft < 20)
        {
            if (add == 1)
                flag2 = false;
            else
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
