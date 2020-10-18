using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject CamChangePoint;
    HJ_CamChangePoint CamChangePointScript;

    bool RockPassCamChangePointCopy;

    public Camera mainC;
    public Camera subC;

    bool rockPassCamChangePoint;

    void Start()
    {
        CamChangePointScript = CamChangePoint.GetComponent<HJ_CamChangePoint>();
        mainC.enabled = true;
        subC.enabled  = false;
    }

    void Update()
    {
        RockPassCamChangePointCopy = CamChangePointScript.RockPassCamChangePoint;
        
        if ( RockPassCamChangePointCopy == true )
        {
            mainC.enabled = false;
            subC.enabled  = true;
        }
       
    }
}
