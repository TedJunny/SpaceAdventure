using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HJ_SpaceShipNull : MonoBehaviour
{
    public GameObject spaceBridgeGoGet;
    public GameObject earth;

    bool spaceShipBridgeUpDoneCopy;
    Vector3 dir;
    float Sspeed = 5; // spaceShip 속도
    HJ_SpaceBridge spaceBridgeScript;

    void Start()
    {
        spaceBridgeScript = spaceBridgeGoGet.GetComponent<HJ_SpaceBridge>();
        dir = earth.transform.position - transform.position;
        dir.Normalize();
    }

    void Update()
    {
        // 다리를 올렸는지 체크
        spaceShipBridgeUpDoneCopy = spaceBridgeScript.spaceShipBridgeUpDone;

        // 다리 올리면 ㅡ> 지구로 출발
        if (spaceShipBridgeUpDoneCopy == true)
        {
            //print("spaceShipBridgeUpDoneCopy == true");

            //for (int i = 1; i <= 500; i++)
            //{
            //    Sspeed = Sspeed + (i / 100);
            //    transform.Translate( -dir * Sspeed * Time.deltaTime);
            //    transform.up = earth.transform.position * Sspeed;
            //}
            
            transform.Translate( -dir * Sspeed * Time.deltaTime);
        }
    }
}
