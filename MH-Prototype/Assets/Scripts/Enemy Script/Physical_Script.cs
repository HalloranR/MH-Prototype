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
    public Tracker_Script god;

    //here is internal vars
    public float moveSpeed = 1f;
    public bool attack = false;
    public LineRenderer line;
    public GameObject particle;

    //variables for attacking
    public float timer;
    public float reset = 7f;
    public float delay = 2f;
    public float length = 10f;


    void Start()
    {
        //fetch vars
        pc = GameObject.FindWithTag("Player").GetComponent<PC_Script>();
        god = GameObject.FindWithTag("GameController").GetComponent<Tracker_Script>();

        //set up the timer
        timer = reset + Random.Range(-delay, delay);
        reset = timer;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //kill enemy here
        if (health <= 0) 
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(gameObject); 
        }

        //trigger the attack after time
        timer -= Time.deltaTime;
        if (timer <= 0) 
        {
            //get the ally location
            ally = god.GetClosest(transform.position);
            Follow();
            timer = reset;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //take damage if the ally runs into the enemy and it is being pulled
        if (col.gameObject.tag == "Ally" && col.gameObject != pc.GetComponent<PC_Script>().ally2)
        {
            //check to make sure the pc is pulling
            bound = pc.bound;

            //make sure the bound ally is dealing damage
            if (bound && col.gameObject == pc.GetComponent<PC_Script>().ally) { health -= lifeLoss; }
        }
        //for the projectile ally
        if (col.gameObject.tag == "ABullet") { health -= lifeLoss; }
    }

    public void Follow()
    {
        //set bool to true so it stops damage
        attack = true;

        Vector3 dir = ally.transform.position - transform.position;

        if (CheckDir(dir))
        {
            dir = dir.normalized * length;

            //keep old z axis
            dir = new Vector3(dir.x, dir.y, 0);
            //print(dir);

            transform.DOMove(transform.position + dir, 1).OnComplete(MyCallback);
        }
        else
        {
            print("change here");
            attack = false;
        }
    }
    public void MyCallback() { if (attack == true) { attack = false; } }

    public bool CheckDir(Vector3 end)
    {
        int mask = 1 << LayerMask.NameToLayer("Pillar");

        RaycastHit2D hit = Physics2D.Raycast(transform.position, end, end.magnitude, mask);

        if (hit)
        {
            if (hit.collider.gameObject.tag == "Pillar")
            {
                //return false;
            }
        }

        return true;
    }
}
