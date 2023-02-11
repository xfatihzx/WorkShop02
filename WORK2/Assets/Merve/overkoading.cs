using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overkoading : MonoBehaviour
{
    int num1;
    int num2;
    int num3;

    // Update is called once per frame
    void Update()
    {

    }

    private int addition(int num1, int num2)
    {
        return num1 + num2;
    }

    private int addition(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }




}
