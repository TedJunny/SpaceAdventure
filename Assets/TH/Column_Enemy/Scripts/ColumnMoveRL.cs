using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMoveRL : MonoBehaviour
{
    float currentTime = 0;
    public float changeTime = 1;
    public float speed = 10;
    Vector3 dir;


    // Start is called before the first frame update
    void Start()
    {
        dir = Vector3.right;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);

        currentTime += Time.deltaTime;

        if (currentTime > changeTime)
        {
            dir = -dir;
            currentTime = 0;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Rock"))
        {
            // Vector3 ContactPoint.point : 충돌지점
            ContactPoint cp = other.GetContact(0);

            // 공의 Y좌표의 Up값
            Vector3 RockYup = other.gameObject.transform.position + Vector3.up * 5;

            // 반사하는 힘의 방향
            Vector3 dir = RockYup - cp.point;

            // 반사힘 적용
            other.rigidbody.AddForce((dir).normalized * 20f, ForceMode.Impulse);
        }
    }
}