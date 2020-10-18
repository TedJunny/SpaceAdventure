using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpin : MonoBehaviour
{
    public float speed;
    public Transform column;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        column.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
    }
}
