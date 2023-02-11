using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinüsControllerSec3 : MonoBehaviour
{
    public bool MinusBool;


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
        MinusBool = true;
        Debug.Log(MinusBool);
    }
    private void OnTriggerExit(Collider other)
    {
        MinusBool = false;
        Debug.Log(MinusBool);
    }
}
