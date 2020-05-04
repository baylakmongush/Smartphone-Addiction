using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintsShowSlid : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    public Sprite hint1;
    public Sprite hint2;
    public Sprite hint3;
    public Sprite hint4;
    public Sprite hint5;
    public Sprite hint6;

    void Start()
    {
        Hint1();
    }

    void Hint1()
    {
        GetComponent<SpriteRenderer>().sprite = hint1;
        Invoke("Hint2", 5f);
    }

    void Hint2()
    {
        GetComponent<SpriteRenderer>().sprite = hint2;
        Invoke("Hint3", 5f);
    }
    void Hint3()
    {
        GetComponent<SpriteRenderer>().sprite = hint3;
        Invoke("Hint4", 5f);
    }
    void Hint4()
    {
        GetComponent<SpriteRenderer>().sprite = hint4;
        Invoke("Hint5", 5f);
    }
    void Hint5()
    {
        GetComponent<SpriteRenderer>().sprite = hint5;
        Invoke("Hint6", 5f);
    }
    void Hint6()
    {
        GetComponent<SpriteRenderer>().sprite = hint6;
        Invoke("Hint1", 5f);
    }
}