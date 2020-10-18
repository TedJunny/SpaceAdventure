using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ted_Finish : MonoBehaviour
{
    AudioSource endingSound;
    public Text clearTimeText;
    public Text highRecordText;
    float currentTime;
    float clearTime;
    // Start is called before the first frame update
    void Start()
    {
        endingSound = GetComponent<AudioSource>();
        highRecordText.text = PlayerPrefs.GetFloat("HighRecord", 999).ToString("00.0");
    }

    // Update is called once per frame
    void Update()
    {
        if (Ted_GamaManager.Instance.timeActive == true)
        {
            currentTime += Time.deltaTime;
           
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Rock"))
        {
            endingSound.Play();
            Ted_GamaManager.Instance.timeActive = false;
            Ted_GamaManager.Instance.endingUI.SetActive(true);
            Ted_GamaManager.Instance.dashboardUI.SetActive(false);
            Ted_SoundManager.Instance.bgmPlayer.Stop();

            clearTime = currentTime;
            clearTimeText.text = currentTime.ToString("00.0");

            if (clearTime < PlayerPrefs.GetFloat("HighRecord", 999))
            {
                PlayerPrefs.SetFloat("HighRecord", clearTime);
                highRecordText.text = clearTime.ToString("00.0");
            }
        }
    }

    public void ResetRecord()
    {
        PlayerPrefs.DeleteAll();
        highRecordText.text = "999";
    }
}
