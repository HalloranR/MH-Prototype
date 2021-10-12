using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Script : MonoBehaviour
{
    public Vector2 dest = new Vector2 (0,0);
    public float speed = 5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, dest, step);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag != "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
