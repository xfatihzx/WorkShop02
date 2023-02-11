using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minüsTrigger : MonoBehaviour
{
    public bool trigger;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    #region trigger enter ve exit
    private void OnTriggerEnter(Collider other)
    {
        trigger = true;
        Debug.Log("trigger minus:  " + trigger);
    }

    private void OnTriggerExit(Collider other)
    {
        trigger = false;
        Debug.Log("trigger minus:  " + trigger);
    }
    #endregion
}
