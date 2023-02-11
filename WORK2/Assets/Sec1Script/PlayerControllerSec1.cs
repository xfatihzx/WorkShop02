using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerSec1 : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private float timerForMinus;

    public MinüsContoroller MinüsContoroller;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerSHealth();
    }

    private void PlayerSHealth()
    {
        if (MinüsContoroller.isTriggerMinus == true)
        {
            timerForMinus += Time.deltaTime;

            if (timerForMinus >= 1)
            {
                health--;
                timerForMinus = 0;
            }
            Debug.Log(health);
        }

        if (health>100)
        {
            health = 100;
        }

        if (health<0)
        {
            health = 0;
        }
    }




}
