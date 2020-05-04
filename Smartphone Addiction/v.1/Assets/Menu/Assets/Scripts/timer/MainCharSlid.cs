using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainCharSlid : MonoBehaviour
{
    public Slider mySlider;

    public int timeLeft = 35;
    private float gameTime;
    public Slider_microwave flag;
    public Charging_slid flag2;
    public Child_slid child;

    // Update is called once per frame
    void Update()
    {
       mySlider.value = timeLeft;
            gameTime += 1 * Time.deltaTime;
            if (gameTime >= 1)
            {
            if ((flag.animat || flag2.flag2 == false || child.child == false) && timeLeft > 0)
                timeLeft -= 1;
            else
                timeLeft += 1;
            gameTime = 0;
            }
        if (timeLeft == 0)
            SceneManager.LoadScene("GAMEOVER");
    }
}
