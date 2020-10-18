using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Bullet : MonoBehaviour
{
    public GameObject shootExpFactory;
    GameObject exp;
    public AudioSource bulletAudio;

    Vector3 dir;
    public float speed = 10;
    public float destroyTime = 3;

    void Start()
    {
        GameObject target = GameObject.Find("Rock");
        dir = target.transform.position - transform.position;
        dir.Normalize();
        bulletAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        exp = Instantiate(shootExpFactory);
        exp.transform.position = transform.position;
        Destroy(exp, 0.7f);

        transform.Translate(dir * speed * Time.deltaTime);
        bulletAudio.Play();
        Destroy(bulletAudio, 0.05f);
    
        

        Destroy(gameObject, destroyTime);
    }
}


