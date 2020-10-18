using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileAniB_2 : MonoBehaviour
{
    float speed = 6;
    Vector3 dir;
    Vector3 startPos;
    Vector3 outGo;

    void Start()
    {
        startPos = transform.position;
        dir = new Vector3(0, 0, 1);
    }

    void Update()
    {
        Vector3 nowPos = transform.position;
        //print(nowPos.z);

        transform.Translate( dir * speed * Time.deltaTime );

        if ( nowPos.z < startPos.z - 10 )
        {
            dir = new Vector3(0, 0, -1);
        }

        if ( nowPos.z >= startPos.z )
        {
            dir = new Vector3(0, 0, 1);
        }
    }
}
