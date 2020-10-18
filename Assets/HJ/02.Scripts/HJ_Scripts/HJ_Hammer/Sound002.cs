using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound002 : MonoBehaviour
{
    AudioSource audioSource;
    Hammer002 H002;
    float currRotCopy;
    float startRotCopy;
    
    public AudioClip soundfx;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = soundfx;

        H002 = GetComponent<Hammer002>();
        startRotCopy = H002.startRot;

        audioSource.volume = 0.5f;
        audioSource.loop = false;
        audioSource.mute = false;
    }

    void Update()
    {
        currRotCopy = H002.currRot;

        //  startRotCopy = -30
        //  -120 < currRotCopy < -60
        if ( currRotCopy < startRotCopy - 120 ||
             currRotCopy > startRotCopy )
        {
            audioSource.Play();
        }
    }
}
