using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HJ_SpaceShip : MonoBehaviour
{
    public GameObject arriveColliderGet;
    
    // bool spaceshipDown = false;
    bool rockArriveCopy;   

    [HideInInspector]
    public bool spaceShipStop;
    
    float speedY = 5;
    float velY;
    float startPosY;
    
    HJ_Coll_ArriveRock arriveRockGetScript;
    

    void Start()
    {
        arriveRockGetScript = arriveColliderGet.GetComponent<HJ_Coll_ArriveRock>();
        
        startPosY = transform.position.y;
    }

    void Update()
    {
        // Rock이 도착했는지 계속 체크
        rockArriveCopy = arriveRockGetScript.rockArrive;

        float posY = transform.position.y;

        // Rock이 도착하면 ㅡ> 우주선 하강
        if (rockArriveCopy == true)
        {
            // 우주선 : 도킹 위치에 오면 멈춤
            if (posY <= startPosY - 15)
            {
                speedY = 0;
                // 우주선 멈춤 ㅡ> 다리 내림
                spaceShipStop = true;
            }

            // 우주선 하강 
            velY = speedY * Time.deltaTime;
            transform.Translate(new Vector3(0, -velY, 0), Space.Self);
        }       
    }   
}
