using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tracker_Script : MonoBehaviour
{
    public List<GameObject> allies = new List<GameObject>();
    public List<GameObject> enemies = new List<GameObject>();
    public List<GameObject> enemies2 = new List<GameObject>();
    public AudioSource source;

    int gameover = 1;
    public int gamewin = 0;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {        
        if (enemies.Count <= 0)
        {
            if (enemies2.Count <= 0)
            {
                SceneManager.LoadScene(gamewin);
            }
        }

        if(allies.Count <= 0)
        {
            SceneManager.LoadScene(gameover);
        }
    }

    public GameObject GetClosest(Vector3 location)
    {
        GameObject best = null;

        foreach(GameObject ally in allies)
        {
            if(ally == null) { continue; }
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

    public GameObject GetClosestEnemy(Vector3 location)
    {
        GameObject best = null;

        if (enemies.Count > 0)
        {
            foreach (GameObject enemy in enemies)
            {
                if (best == null) { best = enemy; }
                else
                {
                    Vector3 end = best.transform.position;
                    if ((location - end).magnitude > (location - enemy.transform.position).magnitude)
                    {
                        best = enemy;
                    }
                }
            }
        }
        else
        {
            foreach (GameObject enemy in enemies2)
            {
                if (best == null) { best = enemy; }
                else
                {
                    Vector3 end = best.transform.position;
                    if ((location - end).magnitude > (location - enemy.transform.position).magnitude)
                    {
                        best = enemy;
                    }
                }
            }
        }

        return best;
    }
}
