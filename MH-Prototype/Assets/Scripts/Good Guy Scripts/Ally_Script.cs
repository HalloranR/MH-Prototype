using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ally_Script : MonoBehaviour
{
    //internal variables
    public int health = 5;
    public int damage = 1;
    public bool on = false;
    public GameObject particle;
    public Tracker_Script god;

    //variable for health bar
    public HealthBar_Script healthBar;

    void Start()
    {
        //set the healthbar up
        healthBar.SetMaxHealth(health);
        god = GameObject.FindWithTag("GameController").GetComponent<Tracker_Script>();
        god.allies.Add(gameObject);
    }

    void Update()
    {
        if (health <= 0) 
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            god.allies.Remove(gameObject);
            //destroy the object
            Destroy(gameObject);
        }
    }

    public void Damage()
    {
        //function to handle damage
        health -= damage;
        healthBar.SetHealth(health);
    }

    public void Turnon() { gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().enabled = true; }
    public void Turnoff() { gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().enabled = false; }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            col.GetComponent<Enemy_Script>().Damage(10);
        }
        else if (col.gameObject.tag == "Bullet") 
        { 
            Damage();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "Enemy2")
        {
            bool yes = col.gameObject.GetComponent<Physical_Script>().attack;
            //print(yes);
            if (yes) { Damage(); }
            else
            {
                col.GetComponent<Physical_Script>().Damage(10);
            }
        }
        else if (col.gameObject.tag == "Blast")
        {
            Damage();
        }
    }
}
