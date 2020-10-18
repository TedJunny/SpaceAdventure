using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HJ_CamChangePoint : MonoBehaviour
{
    [HideInInspector]
    public bool RockPassCamChangePoint = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Contains("Rock"))
        {
            RockPassCamChangePoint = true;
        }
    }
}
