using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        Test1();
    }

    int number1 = 0;
    int number2 = 2;
    int total;

    private void Test1()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Console.WriteLine("iki sayýyý toplayan program. ");
            total = number1 + number2;

            Console.WriteLine("total: " + total);
            Debug.Log(total);
        }
    }
