using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally2_Script : MonoBehaviour
{
    //internal variables
    public int health = 5;
    public int damage = 1;
    public bool on = false;
    public bool pull = false;

    //variable for health bar
    public HealthBar_Script healthBar;

    //variables for shooting
    public float timer = 5f;
    public float reset = 5f;

    //things to fetch
    public Tracker_Script god;
    public GameObject enemy;
    public GameObject pc;
    public PC_Script pcScript;
    public GameObject particle;


    void Start()
    {
        //set the healthbar up
        healthBar.SetMaxHealth(health);
        god = GameObject.FindWithTag("GameController").GetComponent<Tracker_Script>();
        pc = GameObject.FindWithTag("Player");
        pcScript = pc.GetComponent<PC_Script>();
    }

    void Update()
    {
        //timer for enemy to shoot
        timer -= Time.deltaTime;
        if (timer <= 0) { Shoot(); }

        if (health <= 0)
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }

        if (pull == true)
        {
            if (pcScript.bound == true)
            {
                //timer <= 4.7;
                if (false)
                {
                    ShootsFired();
                }
            }
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

    public void ShootsFired()
    {
        //reset the timer
        timer = reset;

        //create the new bullet
        for (int i = 0; i < 2; i++)
        {
            GameObject rBullet = (GameObject)Instantiate(Resources.Load("ABullet"));
            rBullet.transform.position = new Vector3(transform.position.x, transform.position.y, -2);

            Vector3 angle = transform.position - pc.transform.position;

            if (i == 0) { angle = new Vector3(angle.y, -angle.x, angle.z); }
            if (i == 1) { angle = new Vector3(-angle.y, angle.x, angle.z); }

            //call the function in the bullet script
            rBullet.GetComponent<ABullet_Script>().Target(angle);
        }
    }

    public void Turnon() 
    { 
        gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
        pull = true;
    }
    public void Turnoff() 
    { 
        gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
        pull = false;
    }
}
