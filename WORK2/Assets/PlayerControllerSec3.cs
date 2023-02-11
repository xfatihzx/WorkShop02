using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerSec3 : MonoBehaviour
{
    public MinüsControllerSec3 MinüsControllerSec3;

    [SerializeField] private int health;
    [SerializeField] private float timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayersHealth();
    }

    private void PlayersHealth()
    {
        if (MinüsControllerSec3.MinusBool == true)
        {
            timer += Time.deltaTime;

            if (timer >=1)
            {
                health--;
                timer = 0;
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
