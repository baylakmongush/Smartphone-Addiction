using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void   Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            SceneManager.LoadScene("Scene0");
    }
}
