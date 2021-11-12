using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally2_Script : MonoBehaviour
{
    //internal variables
    public int health = 5;
    public int damage = 1;
    public bool on = false;

    //variable for health bar
    public HealthBar_Script healthBar;

    //variables for shooting
    public float timer = 5f;
    public float reset = 5f;

    //things to fetch
    public Tracker_Script god;
    public GameObject enemy;


    void Start()
    {
        //set the healthbar up
        healthBar.SetMaxHealth(health);
        god = GameObject.FindWithTag("GameController").GetComponent<Tracker_Script>();
    }

    void Update()
    {
        //timer for enemy to shoot
        timer -= Time.deltaTime;
        if (timer <= 0) { Shoot(); }

        if (health <= 0)
        {
            //destroy the object
            Destroy(this.gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        //take damage if the object is a bullet, change the health bar
        if (col.gameObject.tag == "Bullet") { Damage(); }

        //take damage if the object is a physical enemy and it is attacking
        if (col.gameObject.tag == "Enemy2")
        {
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

    public void Shoot()
    {
        //reset the timer
        timer = reset;

        //create the new bullet
        GameObject rBullet = (GameObject)Instantiate(Resources.Load("ABullet"));
        rBullet.transform.position = new Vector3(transform.position.x, transform.position.y, -2);

        //get the ally location
        enemy = god.GetClosestEnemy(transform.position);

        //call the function in the bullet script
        rBullet.GetComponent<ABullet_Script>().Target(enemy.transform.position);
    }

    public void Turnon() { gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true; }
    public void Turnoff() { gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false; }
}
