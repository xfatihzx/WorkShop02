using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minisSEc2 : MonoBehaviour
{
    public bool triggerMinüsSec2;

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
        triggerMinüsSec2 = true;
        Debug.Log(triggerMinüsSec2);
    }

    private void OnTriggerExit(Collider other)
    {
        triggerMinüsSec2 = false;
        Debug.Log(triggerMinüsSec2);
    }
}
