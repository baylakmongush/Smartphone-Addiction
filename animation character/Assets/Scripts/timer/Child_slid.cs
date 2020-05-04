using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Child_slid : MonoBehaviour
{
    public Slider mySlider;

    public int timeLeft = 10;
    private float gameTime;

    // Update is called once per frame
    void Update()
    {
        mySlider.value = timeLeft;
        gameTime += 1 * Time.deltaTime;
        if (gameTime >= 1)
        {
            timeLeft -= 1;
            gameTime = 0;
        }
    }
}
