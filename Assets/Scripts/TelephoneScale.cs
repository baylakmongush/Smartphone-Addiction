using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class TelephoneScale : MonoBehaviour
{
    int click = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //7.96 -1.98
    //8.33 -6.85
    // Update is called once per frame
    void Update()
    {
    }

    private float gametime;

    void OnMouseDown()
    {
        if (click == 0)
        {
            float x, y;
            int count = 0;
            x = 8.33f;
            y = -6.85f;
            while (count < 5)
            {
                y += count * 0.474f;
                transform.localPosition = new Vector3(x, y, 2);
                count += 1;
                //}               
            }
            
            click = 1;
        }
        Debug.Log("Click");
    }
}
