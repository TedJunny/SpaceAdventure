using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HJ_MiniBridge : MonoBehaviour
{
    float startPosX;
    float currPosX;
    float posX;
    float goX;

    void Start()
    {
        Vector3 startPos = transform.position;
        startPosX = startPos.x;
    }

    void Update()
    {
        currPosX = transform.position.x;

        //if ( currP )
        //transform.position += new Vector3( goX * Time.deltaTime, 0, 0);
    }
}
