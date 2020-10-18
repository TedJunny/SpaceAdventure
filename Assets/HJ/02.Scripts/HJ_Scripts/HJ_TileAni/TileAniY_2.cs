using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileAniY_2 : MonoBehaviour
{
    float speed = 4;
    Vector3 dir;
    Vector3 startPos;
    Vector3 outGo;

    void Start()
    {
        outGo = new Vector3(1, 0, 0);
        dir = outGo;
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 nowPos = transform.position;
        
        transform.Translate( dir * speed * Time.deltaTime );

        if ( nowPos.x > startPos.x + 5 )
        {
            // dir = new Vector3(-1,0,0);
            dir = -outGo;
        }

        if ( nowPos.x < startPos.x )
        {
            // dir = new Vector3(1, 0, 0);
            dir = outGo;
        }
    }
}
