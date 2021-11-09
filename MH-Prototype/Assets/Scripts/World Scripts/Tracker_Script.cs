using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tracker_Script : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject[] enemies2 = GameObject.FindGameObjectsWithTag("Enemy2");
        if (enemies.Length <= 0)
        {
            if (enemies2.Length <= 0)
            {
                print("here none");
                SceneManager.LoadScene(2);
            }
        }
    }
}
