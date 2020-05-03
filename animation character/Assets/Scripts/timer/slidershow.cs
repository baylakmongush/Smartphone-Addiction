using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slidershow : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    public Sprite phone1;
    public Sprite phone2;

    void Start()
    {
        Phone1();
    }

    void Phone1()
    {
        transform.localScale = new Vector3(1.5f, 1.5f, 0);
        GetComponent<SpriteRenderer>().sprite = phone1;
        Invoke("Phone2", 2f);
    }

    void Phone2()
    {
        transform.localScale = new Vector3(1.5f, 1.5f, 0);
        GetComponent<SpriteRenderer>().sprite = phone2;
        Invoke("Phone1", 2f);
    }
}
