using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string soundName;
    public AudioClip clip;
}

public class Ted_SoundManager : MonoBehaviour
{
    [Header("BGM 등록")]
    [SerializeField] Sound[] bgmSounds;

    [Header("BGM 플레이어")]
    public AudioSource bgmPlayer;

    public static Ted_SoundManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayRandomBGM();

    }
   
    public void PlayRandomBGM()
    {
        List<int> list = new List<int>();
        for (int i = 0; i < bgmSounds.Length; i++)
        {
            list.Add(i);
        }
        for (int i = 0; i < bgmSounds.Length; i++)
        {
            int random = list[Random.Range(0, list.Count)];
            list.Remove(random);
            bgmPlayer.clip = bgmSounds[random].clip;
            bgmPlayer.Play();

        }
    }
}
