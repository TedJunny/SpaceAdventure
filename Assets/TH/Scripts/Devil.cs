using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Devil : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 20;

    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        int result = Random.Range(0, 100);
        if (result < 50)
        {
            GameObject target = GameObject.Find("LeftDead");
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        else
        {
            GameObject target2 = GameObject.Find("RightDead");
            dir = target2.transform.position - transform.position;
            dir.Normalize();
        }

    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Rock"))
        {
            transform.Translate(dir * speed * Time.deltaTime);
        }

    }
}
