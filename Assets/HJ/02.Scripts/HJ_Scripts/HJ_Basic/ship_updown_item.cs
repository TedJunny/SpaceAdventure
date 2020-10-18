using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_updown_item : MonoBehaviour
{
    Vector3 pos;
    float startPosY;
    float startPosZ;
    float posY;
    float posZ;
    public float speed = 2.0f;
    int dir = 1;

    void Start()
    {
        startPosY = transform.position.y;
        //startPosZ = transform.position.z;
    }

    void Update()
    {
        posY = transform.position.y;

        transform.Translate(new Vector3(0,1,0) * dir * speed * Time.deltaTime);

        if ( posY > startPosY + 2 )
        {
            dir = -1;  
        }

        if (posY < startPosY - 2 )
        {
            dir = 1;
        }
    }
}
