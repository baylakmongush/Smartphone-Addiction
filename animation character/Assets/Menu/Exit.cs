using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            Application.Quit();
    }
}
