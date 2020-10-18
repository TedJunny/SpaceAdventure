using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ted_ButtonFX : MonoBehaviour
{
    public AudioSource btnFx;
    public AudioClip hoverFX;
    public AudioClip clickFX;

    public void HoverSound()
    {
        btnFx.PlayOneShot(hoverFX);
    }

    public void ClickSound()
    {
        btnFx.PlayOneShot(clickFX);
    }
}
