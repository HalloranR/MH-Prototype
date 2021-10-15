using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.parent.position + new Vector3(0.5f, 1.7f, -1f);
    }
}
