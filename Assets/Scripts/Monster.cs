using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using hanbin;

public class Monster : MonoBehaviour
{
    public Collider collider;
    //정수
    public int a = 10;
    //실수
    public float b = 11.5f;
    //문자열
    public char c = 'a';
    //문자행
    public string s = "hanbin";
    //참거짓
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
