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
    public AudioSource source;

    //variable for health bar
    public HealthBar_Script healthBar;

    //variables for shooting
    public float timer = 3f;
    public float reset = 3f;

    //things to fetch
    public Tracker_Script god;
    public GameObject enemy;
    public GameObject pc;
    public PC_Script pcScript;
    public GameObject particle;


    void Start()
    {
        source = GetComponent<AudioSource>();
        //set the healthbar up
        healthBar.SetMaxHealth(health);
        god = GameObject.FindWithTag("GameController").GetComponent<Tracker_Script>();
        pc = GameObject.FindWithTag("Player");
        pcScript = pc.GetComponent<PC_Script>();
        god.allies.Add(gameObject);
    }

    void Update()
    {
        //timer for enemy to shoot
        timer -= Time.deltaTime;
        if (timer <= 0) { Shoot(); }

        if (health <= 0)
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            god.allies.Remove(gameObject);
            Destroy(this.gameObject);
        }

        if (pull == true)
        {
            if (pcScript.pulling == true && pcScript.ally == gameObject && pcScript.bust == false)
            {
                if (timer <= reset-0.15) { ShootsFired(); }
            }
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

        source.Play(0);

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
        Vector3 dir = transform.position - pc.transform.position;
        gameObject.transform.GetChild(2).transform.rotation = Quaternion.Euler(0, 0, Vector3.Angle(new Vector3(0, 1, 0), dir));

        //create the new bullet
        for (int i = 0; i < 2; i++)
        {
            GameObject rBullet = (GameObject)Instantiate(Resources.Load("ABullet"));
            rBullet.transform.position = new Vector3(transform.position.x, transform.position.y, -2);


            Vector3 angle = new Vector3(0,0,0);
            
            //get the right or left child of the rotation
            if (i == 0) { angle = gameObject.transform.GetChild(2).GetChild(0).transform.position; }
            if (i == 1) { angle = gameObject.transform.GetChild(2).GetChild(1).transform.position; }


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

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Destroy(col.gameObject);
            Damage();
        }
        else if (col.gameObject.tag == "Enemy2")
        {
            bool yes = col.gameObject.GetComponent<Physical_Script>().attack;
            //print(yes);
            if (yes) { Damage(); }
        }
        else if (col.gameObject.tag == "Blast")
        {
            Damage();
        }
    }
}
