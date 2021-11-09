using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sense_Script : MonoBehaviour
{
    //senses if an ally moves into the collider
    void OnCollisionEnter2D(Collision2D col)
    {
        //take damage if the ally runs into the enemy and it is being pulled
        if (col.gameObject.tag == "Ally")
        {
            Vector3 pos = col.gameObject.transform.position;
            //call the new function

        }
    }
}
