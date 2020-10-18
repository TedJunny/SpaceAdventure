using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ted_Title : MonoBehaviour
{
    public string sceneName = "GameScene";
    
    public void ClickStart()
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("로딩");
    }
}
