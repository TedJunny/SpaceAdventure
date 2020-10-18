using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HJ_EarthBirth_Coll : MonoBehaviour
{
    [HideInInspector]
    public bool earthBirthColl;

    public GameObject earth;

    private void Start()
    {
        earth.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Contains("Rock"))
        {
            earthBirthColl = true;

            earth.SetActive(true);
        }
    }
}
