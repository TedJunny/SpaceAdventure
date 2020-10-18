using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ted_DontDestroyAudio : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
