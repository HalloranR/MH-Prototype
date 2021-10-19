using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : MonoBehaviour
{
    public Rigidbody2D rb;
    public int health = 10;
    public int lifeLoss = 4;
    public float timer;
    public float reset = 5f;
    public Vector2 ally;
    public float delay = 2f;
    public float ratio = 1.1f;
    public bool bound;
    public PC_Script pc;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        timer = reset + Random.Range(-delay, delay);
        reset = timer;
        pc = GameObject.FindWithTag("Player").GetComponent<PC_Script>();
    }


    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Shoot();
            timer = reset;
        }

        //change velocity here
        Vector3 velocity = rb.velocity;

        if (velocity != new Vector3(0, 0, 0)) 
        {
            //CheckSpeed();
        }

        if (health <= 0) { Destroy(gameObject); }
    }

    private void Shoot()
    {
        GameObject rBullet = (GameObject)Instantiate(Resources.Load("Bullet"));

        rBullet.transform.position = new Vector3(transform.position.x, transform.position.y, -2);

        ally = GameObject.FindWithTag("Ally").transform.position;

        rBullet.GetComponent<Bullet_Script>().Target(ally);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ally")
        {
            bound = pc.bound;

            if (bound) { health -= lifeLoss; }
        }
    }
 
    public void CheckSpeed()
    {
        Vector3 velocity = rb.velocity;

        if (velocity != new Vector3(0, 0, 0))
        {
            rb.velocity = new Vector3(velocity.x / ratio, velocity.y / ratio, velocity.z / ratio);
        }
    }
}
