using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_updown : MonoBehaviour
{
    Vector3 pos;
    Vector3 curPos;
    float posY;
    float curPosY;
    public float speed = 2.5f;
    int dir = 1;
    bool arrive = false;
    bool it;

    //public GameObject goal;

    //Vector3 v;

    void Start()
    {
        // v = goal.transform.position - transform.position;
        // v.Normalize();
        curPos = transform.position;
        curPosY = curPos.y;

    }

    void Update()
    {
        pos = transform.position;
        posY = pos.y;

        // 공이 오기전 : 상하움직임
        if ( arrive == false )
        {
            transform.Translate(Vector3.up * dir * speed * Time.deltaTime);

            if (posY > curPosY + 1)
            {
                dir = -1;
            }

            if (posY < curPosY - 3)
            {
                dir = 1;
            }
        }
        else if ( arrive == true )
        {
            // 도착하면 위아래 움직임 멈춤 
            transform.position = transform.position;

        }           
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.name.Contains("Rock"))
        {
            arrive = true;
        }
    }

    //void Go()
    //{
       // transform.Translate(v * speed * Time.deltaTime);
    //}

}
