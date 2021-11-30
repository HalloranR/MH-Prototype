using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : MonoBehaviour
{
    //things i need to fetch
    public Rigidbody2D rb;
    public GameObject ally;
    public PC_Script pc;
    public Tracker_Script god;
    public bool bound;
    public GameObject particle;
    
    //internal variables
    public int health = 10;
    public int lifeLoss = 4;
    public float ratio = 1.1f;
    
    //variables for shooting
    public float timer;
    public float reset = 5f;
    public float delay = 2f;
    public LayerMask pillarLayer;
    public Vector3 allyLoc; 

    void Start()
    {
        //get objects for easy access
        rb = this.GetComponent<Rigidbody2D>();
        pc = GameObject.FindWithTag("Player").GetComponent<PC_Script>();
        god = GameObject.FindWithTag("GameController").GetComponent<Tracker_Script>();

        //set up the timer
        timer = reset + Random.Range(-delay, delay);
        reset = timer;
    }

    void Update()
    {
        //timer for enemy to shoot
        timer -= Time.deltaTime;
        if (timer <= 1.5 && timer >= 1) { Telegraph(); }
        if (timer <= 0) { Shoot(); }

        //change velocity here
        Vector3 velocity = rb.velocity;
        if (velocity != new Vector3(0, 0, 0)) { //CheckSpeed();
        }

        //kill enemy here
        if (health <= 0) 
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(gameObject); 
        }
    }

    public void Shoot()
    {
        //reset the timer
        timer = reset;

        //create the new bullet
        GameObject rBullet = (GameObject)Instantiate(Resources.Load("Bullet"));
        rBullet.transform.position = new Vector3(transform.position.x, transform.position.y, -2);

        if (ally == null) { print("ohho"); }

        //call the function in the bullet script
        rBullet.GetComponent<Bullet_Script>().Target(allyLoc);

        gameObject.transform.GetChild(1).GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //take damage if the ally runs into the enemy and it is being pulled
        if(col.gameObject.tag == "Ally" && col.gameObject != pc.GetComponent<PC_Script>().ally2)
        {
            //check to make sure the pc is pulling
            bound = pc.bound;

            //make sure the bound ally is dealing damage
            if (bound && col.gameObject == pc.GetComponent<PC_Script>().ally) { health -= lifeLoss; }
        }
        //for the projectile ally
        if (col.gameObject.tag == "ABullet") { health -= lifeLoss; }
    }
 
    public void CheckSpeed()
    {
        //trying to add friction here
        Vector3 velocity = rb.velocity;

        if (velocity != new Vector3(0, 0, 0))
        {
            rb.velocity = new Vector3(velocity.x / ratio, velocity.y / ratio, velocity.z / ratio);
        }
    }

    public void Telegraph()
    {
        //get the ally location
        ally = god.GetClosest(transform.position);

        if(ally != null)
        {
            allyLoc = ally.transform.position;

            //print(allyLoc);

            Vector3 dir = allyLoc - transform.position;

            print(dir);

            gameObject.transform.GetChild(1).GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
            gameObject.transform.GetChild(1).transform.rotation = Quaternion.Euler(0, 0, Vector3.Angle(new Vector3(1, 0, 0), dir));

            dir = dir.normalized;
        }
    }
}
