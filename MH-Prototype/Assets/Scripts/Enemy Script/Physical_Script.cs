using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physical_Script : MonoBehaviour
{
    GameObject[] allies;
    // Start is called before the first frame update
    void Start()
    {
        allies = GameObject.FindGameObjectsWithTag("Ally");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GameObject blly = null;
        Vector3 bPos;
        foreach (GameObject ally in allies)
        {
            if (blly == null) 
            { 
                blly = ally;
                bPos = ally.transform.position;
            }
            //find closes position
            

            //if(blly.transform.positi)
        }
    }
}
