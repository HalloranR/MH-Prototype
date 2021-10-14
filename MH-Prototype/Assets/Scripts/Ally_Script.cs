using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally_Script : MonoBehaviour
{
    public int health = 5;
    public int damage = 1;
    public healthbar_Script healthBar;

    void Start()
    {
        healthBar.SetMaxHealth(health);
    }

    void Update()
    {
        if (health <= 0) 
        { 
            Destroy(gameObject); 

        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            health -= damage;
            healthBar.SetHealth(health);
        }
    }
}
