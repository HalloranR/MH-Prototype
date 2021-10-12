using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public int health = 10;
    public int lifeLoss = 4;

    public GameObject pc;

    private float timer = 5f;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        pc = GameObject.FindWithTag("pc");
    }



    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Shoot();
            timer = 5f;
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ally")
        {
            health -= lifeLoss;
        }
    }

    void Shoot()
    {
        Vector2 pcPos = (Vector2)pc.transform.position;
        print(pcPos);
    }
}
