using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KTH_Danger : MonoBehaviour
{
    [SerializeField] KTH_AnimalAI m_animal = null;

    public AudioSource manAudio;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            m_animal.SetTarget(other.transform);
            manAudio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            m_animal.RemoveTarget();
            Destroy(manAudio);
        }
    }
}
