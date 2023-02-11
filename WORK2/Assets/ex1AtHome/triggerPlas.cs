using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerPlas : MonoBehaviour
{
    public bool triggerPlasses;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    #region trigers for plas 
    private void OnTriggerEnter(Collider other)
    {
        triggerPlasses = true;
        Debug.Log("trigger plas:  " + triggerPlasses);
    }

    private void OnTriggerExit(Collider other)
    {
        triggerPlasses = false;
        Debug.Log("trigger plas:  " + triggerPlasses);
    }
    #endregion 
}
