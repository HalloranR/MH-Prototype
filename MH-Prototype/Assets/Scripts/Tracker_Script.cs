using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tracker_Script : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int num = 0;
        if(GameObject.FindGameObjectsWithTag("Enemy") == null)
        {
            print("here none");
            SceneManager.LoadScene(2);
        }
    }
}
