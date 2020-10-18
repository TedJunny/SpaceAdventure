using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Ted_RockMove : MonoBehaviour
{
    public float speed = 10f;
    public float jumpPower = 35f;
    private Rigidbody rb;
    private bool onGround = true;
    public Text speedIndicator;
    float h, v;
    AudioSource jumpSound;
    // AudioSource rollingSound;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpSound = GetComponent<AudioSource>();
        // rollingSound = GetComponent<AudioSource>();
    }


    void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal"); // x축 입력값
        v = Input.GetAxis("Vertical"); // y축 입력값

        if (onGround == true) // 공이 바닥에 있을 때의 물리적용
        {
            Vector3 dir = new Vector3(h, 0, v); // 방향 벡터 dir 변수 선언 (로컬 좌표)
            dir = Camera.main.transform.TransformDirection(dir); // 카메라 시점 기준으로 이동하기 위해 
                                                                 // 방향 벡터의 좌표기준을 월드 좌표로 변경하는 메소드
            rb.AddForce(dir * speed); // Rigidbody 컴포넌트를 이용하여 플레이어 이동

            float currentSpeed = rb.velocity.magnitude;
            speedIndicator.text = currentSpeed.ToString("00");

            // 바닥 충돌 검사 코드
            Ray ray = new Ray(transform.position, Vector3.down);
            RaycastHit hitInfo;

            if (false == Physics.Raycast(ray, out hitInfo, transform.localScale.y)) // 오브젝트의 y 스케일 만큼 Ray 쏘기
            {
                onGround = false; // Ray에 충돌되지 않았다면 공중에 떠 있는 것으로 판정
            }

        }

        else
        {
            Vector3 dirOnAir = new Vector3(h, 0, v);
            dirOnAir = Camera.main.transform.TransformDirection(dirOnAir);

            rb.AddForce(dirOnAir * speed * 0.3f); // 공중에서도 키입력을 통해서 방향 설정을 할 수 있게 하면서
                                                  // 공의 속도가 급상승 하는 것을 방지하기 위해 가중치를 0.3배 설정함
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && onGround) // 바닥에 있을 때만 점프 가능
        {
            jumpSound.Play();
            rb.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }

    //private void RollingSound()
    //{
    //    rollingSound.Play();
    //    rollingSound.pitch = Mathf.Clamp(rb.velocity.magnitude / speed, 0.8f, 1.2f);

    //}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ObstacleHuman")
        {
            Rigidbody otherRb = other.gameObject.GetComponent<Rigidbody>();
            //otherRb.AddExplosionForce(100, other.transform.position, 1, 10, ForceMode.Impulse);
            Vector3 force = rb.velocity * 5 + Vector3.up * 10;
            otherRb.AddForce(force, ForceMode.Impulse);
        }
        onGround = true;

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, new Vector3(transform.position.x, transform.position.y - transform.localScale.y, transform.position.z));

    }
}



