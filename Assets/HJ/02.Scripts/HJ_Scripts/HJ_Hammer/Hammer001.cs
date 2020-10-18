using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer001 : MonoBehaviour
{
    float Dir;
    float rotSpeed = 50;
    bool empty = false;
    
    [HideInInspector]
    public float currRot;
    [HideInInspector]
    public float startRot;
        
    void Start()
    {
        startRot = transform.eulerAngles.z;
    }

    void Update()
    {
        // -45  ~ -135 
        currRot = transform.eulerAngles.z;
               
        if ( empty == false )
        {
            Dir = -(rotSpeed * Time.deltaTime);
            empty = true;
        }

        if ( currRot < startRot - 120 )
        {
            Dir = rotSpeed * Time.deltaTime;
        }

        if ( currRot > startRot )
        {
            Dir = -(rotSpeed * Time.deltaTime);
        }
        
        transform.Rotate(new Vector3(0, 0, Dir));
    }
}

