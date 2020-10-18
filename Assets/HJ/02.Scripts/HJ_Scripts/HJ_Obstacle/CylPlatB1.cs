using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylPlatB1 : MonoBehaviour
{
    float rotDir;
    float startRot;
    float rotSpeed = 15;
    float currTime;

    void Start()
    {
        rotDir = rotSpeed * Time.deltaTime;
        // startRot = transform.eulerAngles.x;
        startRot = transform.eulerAngles.z; 

        print("startRot " + startRot);
        currTime = Time.time;
    }

    void Update()
    {
        if (Time.time > currTime + 1.5f)
        {
            // 10 ~ 0 ~ 350 
            float currRot = transform.eulerAngles.z;

            if (startRot == currRot)
            {
                StartCoroutine(WaitForIt());
            }

            print("currRot " + currRot);

            //             10+340=[350]                   10+335=[345] 
            if (currRot < startRot + 340 && currRot > startRot + 335)
            {
                rotDir = -(rotSpeed * Time.deltaTime);
            }

            if (currRot > startRot && currRot < startRot + 5)
            {
                rotDir = rotSpeed * Time.deltaTime;
            }

            transform.Rotate(new Vector3(0, 0, -rotDir), Space.Self);
        }
    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(2.0f);        
    }
}

