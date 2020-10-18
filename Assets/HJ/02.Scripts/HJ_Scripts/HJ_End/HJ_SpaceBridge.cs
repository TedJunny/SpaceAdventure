using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HJ_SpaceBridge : MonoBehaviour
{
    // 우주선
    public GameObject spaceShip;
    // 탑승 체크 오브젝트 
    public GameObject COLL_GetOn;

    // 우주선 스크립
    HJ_SpaceShip spaceShipScript;
    // 탑승 체크 스크립
    HJ_RockGetOn rockGetOnScript;

    bool spaceShipStopCopy;
    bool rockGetOnCopy;
    
    [HideInInspector]
    public bool spaceShipBridgeUpDone;

    float upSpeedX = 5;
    float downSpeedX = 5;

    float downVel;
    float upVel;
    float startPosX;    

    void Start()
    {
        // 시작할때 X 위치
        startPosX = transform.position.x;

        spaceShipScript = spaceShip.GetComponent<HJ_SpaceShip>();
        rockGetOnScript = COLL_GetOn.GetComponent<HJ_RockGetOn>();
    }

    void Update()
    {
        // 우주선 하강 멈춤 여부
        spaceShipStopCopy = spaceShipScript.spaceShipStop;
        rockGetOnCopy     = rockGetOnScript.rockGetOn;

        // 다리의 현재 x위치
        float posX = transform.position.x;
        
        // 다리 움직임 속도
        downVel = downSpeedX * Time.deltaTime;
        upVel   = upSpeedX   * Time.deltaTime;

        // 우주선 하강 완료하면  
        if ( spaceShipStopCopy == true )
        {
            // 다리 내리기             
            transform.Translate(new Vector3(downVel, 0, 0), Space.Self);
            
            if (posX < startPosX - 12 )
            {
                // 멈춰라
                downSpeedX = 0;
            }
        }

        // Rock이 탑승 완료하면
        if ( rockGetOnCopy == true )
        {
            // 다리를 올리기
            transform.Translate(new Vector3(-upVel, 0, 0), Space.Self);
            
            if (posX > startPosX)
            {
                // 멈춰라
                upSpeedX = 0;
                spaceShipBridgeUpDone = true;
            }
        }
    }   
}
