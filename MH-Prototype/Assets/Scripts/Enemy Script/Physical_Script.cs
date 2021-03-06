using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Physical_Script : MonoBehaviour
{
    //Life vars
    public int health = 20;
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
    public Color flash = Color.white;
    public Color normal;
    private Renderer rend;

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
        god.enemies2.Add(gameObject);

        rend = GetComponent<Renderer>();

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
            god.enemies2.Remove(gameObject);
            god.source.Play();
            Destroy(gameObject); 
        }

        //trigger the attack after time
        timer -= Time.deltaTime;
        if(timer <= 1.5 && timer > 0.75) { Telegraph(); }
        if (timer <= 0) 
        {
            //get the ally location
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
            if (bound && col.gameObject == pc.GetComponent<PC_Script>().ally) { Damage(lifeLoss); }
        }
        //for the projectile ally
        if (col.gameObject.tag == "ABullet") { Damage(lifeLoss); }
    }

    public void Damage(int deal)
    {
        health -= deal;
        StartCoroutine(Flicker());
    }

    public void Follow()
    {
        Vector3 dir = ally.transform.position - transform.position;

        if (CheckDir(dir))
        {
            attack = true;

            dir = dir.normalized * length;

            //keep old z axis
            dir = new Vector3(dir.x, dir.y, 0);
            //print(dir);

            gameObject.transform.GetChild(0).GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
            transform.DOMove(transform.position + dir, 1).OnComplete(MyCallback);
        }
        else { timer = 1; }
    }
    public void MyCallback() { if (attack == true) { attack = false; } }

    public bool CheckDir(Vector3 end)
    {
        int mask = 1 << LayerMask.NameToLayer("Pillar");

        RaycastHit2D hit = Physics2D.Raycast(transform.position, end, end.magnitude, mask);

        if (hit)
        {
            if (hit.collider.gameObject.tag == "Pillar" || hit.collider.gameObject.tag == "Boarder")
            {
                return false;
            }
        }

        return true;
    }

    IEnumerator Flicker()
    {
        for (int i = 0; i <= 4; i++)
        {
            if (i % 2 == 0) { rend.material.color = flash; }
            else if (i % 2 == 1) { rend.material.color = normal; }
            yield return new WaitForSeconds(0.1f);
        }
    }

    public void BlowUp()
    {
        health -= health;
    }

    public void Telegraph()
    {
        //get the ally location
        ally = god.GetClosest(transform.position);


        if (ally != null)
        {
            Vector3 allyLoc = ally.transform.position;

            Vector3 dir = allyLoc - transform.position;

            //print(dir);
            //print(Vector3.Angle(new Vector3(1, 0, 0), dir));

            if (transform.position.y > allyLoc.y)
            {
                //print("yes");
                gameObject.transform.GetChild(0).GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
                float value = 360 - Vector3.Angle(new Vector3(1, 0, 0), dir);
                gameObject.transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0, value);

            }
            else
            {
                //print("yee");
                gameObject.transform.GetChild(0).GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
                gameObject.transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0, Vector3.Angle(new Vector3(1, 0, 0), dir));
            }
        }
    }
}
