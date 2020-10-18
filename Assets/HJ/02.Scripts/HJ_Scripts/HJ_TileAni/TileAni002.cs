using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileAni002 : MonoBehaviour
{
    public float speed = 5;
    Vector3 dir;
    Vector3 startPos;

    void Start()
    {
        dir = Vector3.forward;
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 nowPos = transform.position;
        transform.Translate( dir * speed * Time.deltaTime );
        //print(nowPos.z);

        if ( nowPos.z < startPos.z - 15 )
        {
            dir = -Vector3.forward;
        }

        if (nowPos.z > startPos.z )
        {
            dir = Vector3.forward;
        }
    }
}
