using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physical_Script : MonoBehaviour
{
    //Life vars
    public int health = 10;
    public int lifeLoss = 10;

    //ally variables
    public PC_Script pc;
    private Rigidbody2D rb;
    public bool bound;
    public GameObject ally;
    GameObject[] allies; //not used

    //here is internal vars
    public float moveSpeed = 17f;
    public bool attack = true;
    public LineRenderer line;

    //variables for attacking
    public float timer;
    public float reset = 5f;
    public float delay = 2f;


    void Start()
    {
        //fetch vars
        pc = GameObject.FindWithTag("Player").GetComponent<PC_Script>();
        ally = GameObject.FindGameObjectWithTag("Ally");
        rb = GetComponent<Rigidbody2D>();

        //set up the timer
        timer = reset + Random.Range(-delay, delay);
        reset = timer;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //kill enemy here
        if (health <= 0) { Destroy(gameObject); }

        //trigger the attack after time
        timer -= Time.deltaTime;
        if (timer <= 0) 
        { 
            Follow();
            timer = reset;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //take damage if the ally runs into the enemy and it is being pulled
        if (col.gameObject.tag == "Ally")
        {
            //check if pc is pulling
            bound = pc.bound;

            if (bound && attack) { health -= lifeLoss; }
        }
    }

    public void Follow()
    {
        //set bool to false so it stops damage
        attack = false;
        print("Here is be");

        //move the enemy in steps using the difference and the pullspeed
        float step = moveSpeed * Time.deltaTime;
        Vector3 difference = transform.position - ally.transform.position;

        //set up the line render
        line.SetPosition(0, transform.position);
        line.SetPosition(1, difference);

        //move the enemy
        rb.MovePosition(ally.transform.position + difference * step);

        //reset everything at the end
        line.SetPosition(0, transform.position);
        line.SetPosition(1, transform.position);
        attack = true;
    }
}
