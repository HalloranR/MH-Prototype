using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_Script : MonoBehaviour
{
    public float x = 0f;
    public float y = 1.7f;
    public float z = -1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.parent.position + new Vector3(0f, 1.7f, -1f);
    }
}
