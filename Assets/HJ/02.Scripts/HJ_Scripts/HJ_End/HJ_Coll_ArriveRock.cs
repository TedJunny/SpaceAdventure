using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HJ_Coll_ArriveRock : MonoBehaviour
{
    [HideInInspector]
    public bool rockArrive = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.name.Contains("Rock"))
        {
            rockArrive = true;
        }
    }
}
