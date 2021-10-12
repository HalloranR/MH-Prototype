using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally_Script : MonoBehaviour
{
    public int health = 5;
    public int damage = 1;

    void Update()
    {
        if (health <= 0) { Destroy(gameObject); }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            health -= damage;
        }
    }
}
