using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound001 : MonoBehaviour
{
    AudioSource audioSource;
    Hammer001 H001;
    float currRotCopy;
    float startRotCopy;
    
    public AudioClip soundfx;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = soundfx;

        H001 = GetComponent<Hammer001>();
        startRotCopy = H001.startRot;

        audioSource.volume = 0.5f;
        audioSource.loop = false;
        audioSource.mute = false;
    }

    void Update()
    {
        currRotCopy = H001.currRot;

        //  startRotCopy = -30
        //  -120 < currRotCopy < -60
        if ( currRotCopy < startRotCopy - 120 ||
             currRotCopy > startRotCopy )
        {
            audioSource.Play();
        }
    }
}
