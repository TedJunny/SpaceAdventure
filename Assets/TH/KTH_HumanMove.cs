using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 돌에 사람이 충돌하면 카메라 방향으로 날라가다가 일정시간 후에 사라진다. 
public class KTH_HumanMove : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 100;
    Vector3 dir;
    int a;
    public float expRadius = 10.0f;
    Vector3 Pos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //GameObject target1 = GameObject.Find("GoodByeLeft");
        //GameObject target2 = GameObject.Find("GoodByeRight");

        //a = Random.Range(0, 10);
        //if (a < 2)
        //{
        //    dir = target1.transform.position - transform.position;
        //}

        //else
        //{
        //    dir = target2.transform.position - transform.position;
        //}

        //dir.Normalize();
    }



    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Player"))
        {       
            rb.AddExplosionForce(300.0f, Pos, expRadius, 300.0f);
        }
    }
}
