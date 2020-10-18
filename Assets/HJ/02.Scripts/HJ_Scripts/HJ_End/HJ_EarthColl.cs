using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HJ_EarthColl : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Contains("SpaceShip"))
        {
            Destroy(other.gameObject);
        }
    }
}
