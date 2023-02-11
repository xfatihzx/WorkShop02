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

    #region player'a ait tüm özellikler burada yer alýr.

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

    #region inTriggerEnterMünis ve tüm özellikleri burada yer alýr.
    private void inTriggerEnterMinus()
    {
       // if (MinusTriggerController.isTrigger == true)
        {
            timerPlas += Time.deltaTime;
            Debug.Log(timerPlas);           //geri sayaç da yap
            
            if (timerPlas >=1)
            {
                health--;
                timerPlas = 0;
            }
        }
        Debug.Log(health);
    }
    #endregion

# region inTriggerEnterPlas ve tüm özellikleri burada yer alýr.

#endregion


}
