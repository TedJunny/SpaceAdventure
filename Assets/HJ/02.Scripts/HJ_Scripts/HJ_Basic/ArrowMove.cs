using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{
    // 움직이는 속도
    public float speed = 1.0f;

    // 재질
    Material mat;
    
    void Start()
    {
        MeshRenderer mr = gameObject.GetComponent<MeshRenderer>();
        mat = mr.sharedMaterial;
    }

    void Update()
    {
        mat.mainTextureOffset -= Vector2.right * speed * Time.deltaTime;
    }
}
