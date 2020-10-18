using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylPlatA3 : MonoBehaviour
{
    float rotDir;
    float startRot;
    float rotSpeed = 10;
    float currTime;

    void Start()
    {
        rotDir = rotSpeed * Time.deltaTime;
        // startRot = transform.eulerAngles.x;
        startRot = transform.eulerAngles.z; 

        //print("startRot " + startRot);
        currTime = Time.time;
    }

    void Update()
    {
        if (Time.time > currTime + 4)
        {
            // 10 ~ 0 ~ 350 
            float currRot = transform.eulerAngles.z;

            //print("currRot " + currRot);

            //             350-340=[10]               350-335=[15]  
            if (currRot > startRot - 340 && currRot < startRot - 335)
            {
                rotDir = -(rotSpeed * Time.deltaTime);
            }

            if (currRot < startRot && currRot > startRot - 5)
            {
                rotDir = rotSpeed * Time.deltaTime;
            }
            transform.Rotate(new Vector3(0, 0, rotDir), Space.Self);
        }
    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(2.0f);
    }
}

