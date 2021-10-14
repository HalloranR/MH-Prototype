using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public int health = 10;
    public int lifeLoss = 4;
    public float timer = 5f;
    public float reset = 5f;
    public Vector2 ally;
    public float delay = 2f;

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
            timer = reset + Random.Range(0f, delay);
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
            health -= lifeLoss;
        }
    }
}
