using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABullet_Script : MonoBehaviour
{
    public Vector2 dest;
    public Vector2 angle;
    public float speed = 5f;
    public float jitter = 0f; //random range

    // Update is called once per frame
    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;

        //what do i do with the angle here?

        transform.position = Vector2.MoveTowards(transform.position, (Vector2)transform.position + angle, step);

        transform.position = new Vector3(transform.position.x, transform.position.y, -1);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag != "Ally" && col.gameObject.tag != "PC" && col.gameObject.tag != "Ally2")
        {
            Destroy(gameObject);
        }
    }

    public void Target(Vector2 target)
    {
        //set the dest and add a little variance if necessary
        dest = new Vector2(target.x, target.y);
        dest = dest + new Vector2(jitter, jitter);

        angle = dest - (Vector2)transform.position;
        angle.Normalize();
    }
}
