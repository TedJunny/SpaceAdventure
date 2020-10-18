﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileAniC_R3 : MonoBehaviour
{
    float speed = 4;
    Vector3 dir;
    Vector3 startPos;
    Vector3 outGo;

    void Start()
    {
        outGo = new Vector3(0, 0, -1);
        dir = outGo;
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 nowPos = transform.position;
        
        transform.Translate( dir * speed * Time.deltaTime );

        if ( nowPos.z > startPos.z + 15 )
        {
            // dir = new Vector3(-1,0,0);
            dir = -outGo;
        }

        if ( nowPos.z <= startPos.z )
        {
            // dir = new Vector3(1, 0, 0);
            dir = outGo;
        }
    }
}
