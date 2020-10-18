using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseAddForce : MonoBehaviour
{
    // 도너츠
    public GameObject Torus;
    
    // 다리 
    public GameObject Leg;
   
    // 머리
    public GameObject Head;
    
    // 에미션 머테리얼
    public Material emMt;

    // 원래 머테리얼
    public Material orMt;

    // 사운드
    public AudioClip fx;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = fx;

        audioSource.volume = 0.7f;
        audioSource.loop = false;
        audioSource.mute = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name.Contains("Rock"))
        {
            // 충돌 효과음
            audioSource.Play();

            // Vector3 ContactPoint.point : 충돌지점
            ContactPoint cp = other.GetContact(0);

            // 공의 Y좌표의 Up값
            Vector3 RockYup = other.gameObject.transform.position + Vector3.up * 6;

            // 반사하는 힘의 방향
            Vector3 dir = RockYup - cp.point;

            // 반사힘 적용
            other.rigidbody.AddForce((dir).normalized * 1300f);

            // Material 바꾸기 
            Torus.GetComponent<MeshRenderer>().material = emMt;
            Head.GetComponent<MeshRenderer>().material = emMt;
            Leg.GetComponent<MeshRenderer>().material = emMt;

            // 1초후 원래대로 돌아오기
            Invoke("RestoreMaterial", 0.2f);
        }
    }

    void RestoreMaterial()
    {
        Torus.GetComponent<MeshRenderer>().material = orMt;
        Head.GetComponent<MeshRenderer>().material = orMt;
        Leg.GetComponent<MeshRenderer>().material = orMt;
    }

}
