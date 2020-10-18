using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WirePunch : MonoBehaviour
{
    Rigidbody rb; 

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Contains("Rock"))
        {
            rb.AddForce(new Vector3(0,0.01f,0), ForceMode.Force);
        }
    }
}
