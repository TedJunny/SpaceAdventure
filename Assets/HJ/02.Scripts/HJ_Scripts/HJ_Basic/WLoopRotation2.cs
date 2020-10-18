using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WLoopRotation2 : MonoBehaviour
{
    float rotY = 20.0f;

    void Start()
    {
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, -rotY * Time.deltaTime, 0), Space.Self);
              
    }
}
