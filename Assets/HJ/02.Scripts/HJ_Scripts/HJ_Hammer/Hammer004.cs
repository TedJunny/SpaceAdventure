using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer004 : MonoBehaviour
{
    float startRot;
    float rotSpeed = 35;
    float Dir;
    bool empty = false;
    
    void Start()
    {
        startRot = transform.eulerAngles.z;
    }

    void Update()
    { 
        // -45  ~ -135 
        float currRot = transform.eulerAngles.z;

        if (empty == false)
        {
            Dir = -(rotSpeed * Time.deltaTime);
            empty = true;
        }

        //             -30-120=[-150]
        if ( currRot < startRot - 120 )
        {
            Dir = -(rotSpeed * Time.deltaTime);   
        }

        if ( currRot > startRot )
        {
            Dir = rotSpeed * Time.deltaTime;
        }

        transform.Rotate(new Vector3(0, 0, -Dir));
    }
}

