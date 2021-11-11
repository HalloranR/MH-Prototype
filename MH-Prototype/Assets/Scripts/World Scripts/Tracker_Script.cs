using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tracker_Script : MonoBehaviour
{
    GameObject[] allies;
    void Awake()
    {
        allies = GameObject.FindGameObjectsWithTag("Ally");
    }

    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject[] enemies2 = GameObject.FindGameObjectsWithTag("Enemy2");
        allies = GameObject.FindGameObjectsWithTag("Ally");
        if (enemies.Length <= 0)
        {
            if (enemies2.Length <= 0)
            {
                SceneManager.LoadScene(2);
            }
        }

        if(allies.Length <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }

    public GameObject GetClosest(Vector3 location)
    {
        GameObject best = null;

        foreach(GameObject ally in allies)
        {
            if (best == null) { best = ally; }
            else
            {
                Vector3 end = best.transform.position;
                if ((location - end).magnitude > (location - ally.transform.position).magnitude)
                {
                    best = ally;
                }
            }
        }

        return best;
    }
}
