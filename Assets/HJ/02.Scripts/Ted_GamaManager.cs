using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// 태어날 때 Ending UI, GameOver UI를 보이지 않게 하고 싶다.
// - 골 인 지점에 도달하면 Ending UI를 보이게 하고 싶다.
// - GameOverZone에 도달하면 GameOVer UI를 보이게 하고 싶다.
// - Ending UI
// - GameOver UI 
public class Ted_GamaManager : MonoBehaviour
{
    //public Text clearTimeText;
    //public Text highRecordText;
    //float currentTime;
    //float clearTime;
    public bool timeActive = true;
    public static Ted_GamaManager Instance; // 싱글톤
    private void Awake()
    {
        Instance = this;
    }

    public GameObject endingUI;
    public GameObject gameOverUI;
    public GameObject dashboardUI;
    void Start()
    {
        endingUI.SetActive(false);
        gameOverUI.SetActive(false);
        dashboardUI.SetActive(true);
        // highRecordText.text = PlayerPrefs.GetFloat("HighRecord", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //if (timeActive == true)
        //{
        //    currentTime += Time.deltaTime;
        //    clearTime = currentTime;
        //    clearTimeText.text = currentTime.ToString("00.0");
        //    if (clearTime < PlayerPrefs.GetFloat("HighRecord", 0))
        //    {
        //        PlayerPrefs.SetFloat("HighRecord", currentTime);
        //    }
        //}


    }

    public void OnclickRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // currentTime = 0;
        timeActive = true;

    }

    public void OnclickQuit()
    {
        Application.Quit();
    }
}
