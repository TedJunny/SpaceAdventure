using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 충돌을 감지해서 GameOverUI를 불러오고 싶다.
public class Ted_GameOverZone : MonoBehaviour
{
    AudioSource gameOverSound;
    // Start is called before the first frame update
    void Start()
    {
        gameOverSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Rock"))
        {
            Ted_SoundManager sm = GameObject.FindObjectOfType<Ted_SoundManager>();

            Ted_GamaManager.Instance.gameOverUI.SetActive(true);
            Ted_GamaManager.Instance.dashboardUI.SetActive(false);
            sm.bgmPlayer.Stop();

            gameOverSound.Play();
            Destroy(other.gameObject);

            // KTH _ 게임오버시 봇을 파괴한다
            GameObject E2 = GameObject.Find("E2");
            Destroy(E2);

            GameObject E7 = GameObject.Find("E7");
            Destroy(E7);

        }
    }


}
