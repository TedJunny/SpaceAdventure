using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotBack7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Rock"))
        {
            // 돌이 봇백을 지나면 봇은 2초 뒤에 사라진다.
            GameObject E7 = GameObject.Find("E7");
            Destroy(E7, 2);
        }
    }
}
