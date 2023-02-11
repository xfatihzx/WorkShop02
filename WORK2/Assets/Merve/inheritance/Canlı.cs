using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canlı
{
    string name;
    string surname;
    int age;



    public Canlı(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }

    Canlı canlı1 = new Canlı("merve", "x", 20);
    Canlı canlı2 = new Canlı("ali","meow", 25);

}
