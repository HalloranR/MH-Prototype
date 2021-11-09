using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : MonoBehaviour
{
    //things i need to fetch
    public Rigidbody2D rb;
    public Vector2 ally;
    public PC_Script pc;
    public bool bound;
    
    //internal variables
    public int health = 10;
    public int lifeLoss = 4;
    public float ratio = 1.1f;
    
    //variables for shooting
    public float timer;
    public float reset = 5f;
    public float delay = 2f;
    public LayerMask pillarLayer;

    void Start()
    {
        //get objects for easy access
        rb = this.GetComponent<Rigidbody2D>();
        pc = GameObject.FindWithTag("Player").GetComponent<PC_Script>();

        //set up the timer
        timer = reset + Random.Range(-delay, delay);
        reset = timer;
        
    }

    void Update()
    {
        //timer for enemy to shoot
        timer -= Time.deltaTime;
        if (timer <= 0) { Shoot(); }

        //change velocity here
        Vector3 velocity = rb.velocity;
        if (velocity != new Vector3(0, 0, 0)) { //CheckSpeed(); 
        }

        //kill enemy here
        if (health <= 0) { Destroy(gameObject); }
    }

    public void Shoot()
    {
        //reset the timer
        timer = reset;

        //create the new bullet
        GameObject rBullet = (GameObject)Instantiate(Resources.Load("Bullet"));
        rBullet.transform.position = new Vector3(transform.position.x, transform.position.y, -2);

        //get the ally location
        ally = GameObject.FindWithTag("Ally").transform.position;

        //call the function in the bullet script
        rBullet.GetComponent<Bullet_Script>().Target(ally);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //take damage if the ally runs into the enemy and it is being pulled
        if(col.gameObject.tag == "Ally")
        {
            //check to make sure the pc is pulling
            bound = pc.bound;

            if (bound) { health -= lifeLoss; }
        }
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
}
