using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControllerSEc2 : MonoBehaviour
{
    public minisSEc2 minisSEc2;

    [SerializeField] private int health;
    [SerializeField] private float timer;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerHealth();
    }

    private void PlayerHealth()
    {
        if (minisSEc2.triggerMinüsSec2 == true)
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            {
                health--;

                timer = 0;
            }
            Debug.Log(health);
        }

        if (health > 100)
        {
            health = 100;
        }

        if (health <= 0)
        {
            health = 0;
        }
    }


}
