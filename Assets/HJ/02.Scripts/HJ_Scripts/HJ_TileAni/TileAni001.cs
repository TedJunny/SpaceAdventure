using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileAni001 : MonoBehaviour
{
    public float speed = 5;
    Vector3 dir;
    Vector3 startPos;

    void Start()
    {
        dir = Vector3.up;
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 nowPos = transform.position;
        transform.Translate( dir * speed * Time.deltaTime );

        if ( nowPos.y > startPos.y + 15 )
        {
            dir = Vector3.down;
        }

        if (nowPos.y < startPos.y - 3)
        {
            dir = Vector3.up;
        }
    }
}
