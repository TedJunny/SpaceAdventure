using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ted_Timer : MonoBehaviour
{
    public Text textTimer;
    float currentTime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Ted_GamaManager.Instance.timeActive == true)
        {
            currentTime += Time.deltaTime;
            textTimer.text = Mathf.Round(currentTime).ToString();

        }
    }
}
