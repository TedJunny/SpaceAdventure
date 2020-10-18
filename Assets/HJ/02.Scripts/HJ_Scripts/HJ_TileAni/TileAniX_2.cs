using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileAniX_2 : MonoBehaviour
{
    float speed = 4;
    Vector3 dir;
    Vector3 startPos;
    Vector3 rightGo;

    void Start()
    {
        rightGo = new Vector3(0, 0, 1);
        dir = -rightGo;
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 nowPos = transform.position;
        
        transform.Translate( dir * speed * Time.deltaTime );

        if ( nowPos.z < startPos.z - 10 )
        {
            // dir = new Vector3(1, 0, 0);
            dir = rightGo;
        }
        if ( nowPos.z > startPos.z )
        {
            // dir = new Vector3(-1,0,0);
            dir = -rightGo;
        }
    }
}
