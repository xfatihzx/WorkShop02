using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minisSEc2 : MonoBehaviour
{
    public bool triggerMin�sSec2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerMin�sSec2 = true;
        Debug.Log(triggerMin�sSec2);
    }

    private void OnTriggerExit(Collider other)
    {
        triggerMin�sSec2 = false;
        Debug.Log(triggerMin�sSec2);
    }
}
