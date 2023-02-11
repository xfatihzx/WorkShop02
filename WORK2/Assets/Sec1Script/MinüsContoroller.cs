using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinüsContoroller : MonoBehaviour
{
    public bool isTriggerMinus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region triggers thing for sec1
    private void OnTriggerEnter(Collider other)
    {
        isTriggerMinus = true;
        Debug.Log(isTriggerMinus);
    }

    private void OnTriggerExit(Collider other)
    {
        isTriggerMinus = false;
        Debug.Log(isTriggerMinus);
    }
    #endregion
}
