using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{



    private float health;
    [SerializeField] float timerPlas;

    void Start()
    {
        health = 100;


    }


    void Update()
    {
        healthController();
        inTriggerEnterMinus();
        Debug.Log(health);
    }

    #region player'a ait t�m �zellikler burada yer al�r.

    private void healthController()
    {
        if (health < 0)
        {
            health = 0;
        }
        else if (health >= 100)
        {
            health = 100;
        }
    }
    #endregion

    #region inTriggerEnterM�nis ve t�m �zellikleri burada yer al�r.
    private void inTriggerEnterMinus()
    {
       // if (MinusTriggerController.isTrigger == true)
        {
            timerPlas += Time.deltaTime;
            Debug.Log(timerPlas);           //geri saya� da yap
            
            if (timerPlas >=1)
            {
                health--;
                timerPlas = 0;
            }
        }
        Debug.Log(health);
    }
    #endregion

# region inTriggerEnterPlas ve t�m �zellikleri burada yer al�r.

#endregion


}
