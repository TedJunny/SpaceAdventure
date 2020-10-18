using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopRotation_sqaure : MonoBehaviour
{
    public float rot = -10.0f;
    int randomNum;
    Vector3 rotate;

    void Start()
    {
        randomNum = Random.Range(0, 360);
        transform.rotation = Quaternion.Euler(0, 0, randomNum);
    }

    void Update()
    {
        //rotate = new Vector3(0, 0, randomNum);

        //transform.localRotation = Quaternion.Euler(rotate);

        transform.Rotate(0, 0, rot * Time.deltaTime);     
    }
}
