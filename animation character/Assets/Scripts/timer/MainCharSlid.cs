using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCharSlid : MonoBehaviour
{
    public Slider mySlider;

    public int timeLeft = 35;
    private float gameTime;
    public Slider_microwave flag;
    public Charging_slid flag2;

    // Update is called once per frame
    void Update()
    {
       mySlider.value = timeLeft;
            gameTime += 1 * Time.deltaTime;
            if (gameTime >= 1)
            {
                if ((flag.animat || flag2.flag2 == false) && timeLeft > 0)
                    timeLeft -= 1;
                else if (timeLeft < 35)
                    timeLeft += 1;
                gameTime = 0;
            }
    }
}
