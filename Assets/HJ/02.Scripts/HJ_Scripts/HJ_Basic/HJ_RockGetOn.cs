using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HJ_RockGetOn : MonoBehaviour
{
    [HideInInspector]
    public bool rockGetOn = false;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Contains("Rock"))
        {
            rockGetOn = true;
            Destroy(other.gameObject);
        }
    }











    /*
    public GameObject ship;
    public GameObject goal;
    float speed = 5.0f;
    public static bool spaceShipStart = false;
    Vector3 v;

    void Start()
    {
        //v = goal.transform.position - ship.transform.position;
        //v.Normalize();
    }

    void Update()
    {
        if ( spaceShipStart == true )
        {
            //ship.transform.Translate( v * speed * Time.deltaTime );
            ship.transform.Translate( Vector3.forward * speed * Time.deltaTime );
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        // 락이 탑승하면 
        if(other.gameObject.name.Contains("Rock") == true)
        {
            // 락을 없애고
            Destroy(other.gameObject);

            // 우주선 출발키 = 트루
            spaceShipStart = true;

        }
    }
    */

}
