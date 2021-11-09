using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ally_Script : MonoBehaviour
{
    //internal variables
    public int health = 5;
    public int damage = 1;

    //variable for health bar
    public HealthBar_Script healthBar;

    void Start()
    {
        //set the healthbar up
        healthBar.SetMaxHealth(health);
    }

    void Update()
    {
        if (health <= 0) 
        { 
            //destroy the object and end the game if dead
            Destroy(gameObject);
            SceneManager.LoadScene(1);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        //take damage if the object is a bullet, change the health bar
        if (col.gameObject.tag == "Bullet") { Damage(); }

        //take damage if the object is a physical enemy and it is attacking
        if (col.gameObject.tag == "Enemy2")
        {
            print("hit!");
            bool yes = col.gameObject.GetComponent<Physical_Script>().attack;
            print(yes);
            if (yes) { Damage(); }
        }
    }

    public void Damage()
    {
        //function to handle damage
        health -= damage;
        healthBar.SetHealth(health);
    }
}
