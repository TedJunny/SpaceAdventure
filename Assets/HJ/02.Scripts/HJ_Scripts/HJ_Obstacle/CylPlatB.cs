using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylPlatB : MonoBehaviour
{
    float rotDir;
    float startRot;
    float rotSpeed = 15;
    
    void Start()
    {
        rotDir = rotSpeed * Time.deltaTime;
        // startRot = transform.eulerAngles.x;
        startRot = transform.eulerAngles.z; 

        print("startRot " + startRot);        
    }

    void Update()
    {        
        // 10 ~ 0 ~ 350 
        float currRot = transform.eulerAngles.z;

        print("currRot " + currRot);

        //             10+340=[350]                   10+335=[345] 
        if (currRot < startRot + 340 && currRot > startRot + 335 )
        {
            rotDir = -(rotSpeed * Time.deltaTime);
        }

        if (currRot > startRot && currRot < startRot + 5 )
        {
            rotDir = rotSpeed * Time.deltaTime;
        }

        transform.Rotate(new Vector3( 0, 0, -rotDir) , Space.Self); 
    }
}

