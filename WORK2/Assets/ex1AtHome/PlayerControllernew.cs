using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllernew : MonoBehaviour
{
    public minüsTrigger minüsTrigger;
    public triggerPlas triggerPlas;

    [SerializeField] private float health;
    [SerializeField] private float timer;
    [SerializeField] private float timer2;
    [SerializeField] private float timerForEx;

    void Start()
    {
        health = 100;
    }


    void Update()
    {
        PlayersHealth();
    }


    #region players things.

    #region minus triggers things
    private void PlayersHealth()  // ileri ve geri timer ekle (control statment)
    {
        if (minüsTrigger.trigger == true)
        {
            timer += Time.deltaTime;

            if (timer >= 1)
            {
                health--;
                timer = 0;
            }
            Debug.Log("healt is: " + health);
        }

        if (triggerPlas.triggerPlasses == true)
        {
            timer2 += Time.deltaTime;

            if (timer2 >= 1)
            {
                health++;
                timer2 = 0;
            }
            Debug.Log("healt is: " + health);

        }

        if (health <= 0)
        {
            health = 0;
        }

        if (health >= 100)
        {
            health = 100;
        }
    }
    #endregion
    #endregion


    #region timer ex and etc.
    private void timerMinüs()  // for just example. its not fuctional.
    {
        timerForEx -= Time.deltaTime;

        if (timerForEx <= 0)
        {
            // statment
        }
    }
    #endregion
}
