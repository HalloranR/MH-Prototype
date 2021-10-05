using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public int health = 10;
    public int lifeLoss = 4;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
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
}
