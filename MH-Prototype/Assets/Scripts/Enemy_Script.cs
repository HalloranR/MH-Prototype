using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : MonoBehaviour
{
    public Rigidbody2D rb;
    public int health = 10;
    public int lifeLoss = 4;
    public float timer = 5f;
    public float reset = 5f;
    public Vector2 ally;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Shoot();
            timer = reset;
        }

        if (health <= 0) { Destroy(gameObject); }
    }

    private void Shoot()
    {
        GameObject rBullet = (GameObject)Instantiate(Resources.Load("Bullet"));

        ally = GameObject.FindWithTag("Ally").transform.position;

        rBullet.GetComponent<Bullet_Script>().dest = ally;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ally")
        {
            health -= lifeLoss;
        }
    }
}
