using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopRotation : MonoBehaviour
{
    public float rotZ = 10.0f;

    void Start()
    {
    }

    void Update()
    {
        //rotZ = rotZ * Time.deltaTime;
        transform.Rotate(new Vector3(0, 0, rotZ * Time.deltaTime), Space.Self);
    }
}
