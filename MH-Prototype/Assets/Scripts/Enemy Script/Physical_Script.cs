using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
    public float moveSpeed = 1f;
    public bool attack = false;
    public LineRenderer line;

    //variables for attacking
    public float timer;
    public float reset = 7f;
    public float delay = 2f;
    public float length = 10f;


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

            if (bound && !attack) { health -= lifeLoss; }
        }
    }

    public void Follow()
    {
        //set bool to true so it stops damage
        attack = true;

        Vector3 dir = ally.transform.position - transform.position;
        dir = dir.normalized * length;
        //keep old z axis
        dir = new Vector3(dir.x, dir.y, 0);
        print(dir);

        transform.DOMove(transform.position + dir, 1).OnComplete(MyCallback);

    }

    public void MyCallback()
    {
        if (attack == true) { attack = false; }
    }
}
