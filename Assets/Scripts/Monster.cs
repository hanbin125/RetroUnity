using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using hanbin;

public class Monster : MonoBehaviour
{
    public Collider collider;
    public int a = 10;
    public float b = 11.5f;
    public char c = 'a';
    public string s = "hanbin";
    public bool d = true;

    public int playerMovement;

    void Start()
    {
        Add(1.5f, 2.5f);
    }

    void Update()
    {

    }

    public float Add(float e, float f)
    {
        return e + f;
    }
}
