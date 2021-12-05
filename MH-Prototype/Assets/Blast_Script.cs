using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast_Script : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            col.GetComponent<Enemy_Script>().BlowUp();
        }
        else if(col.gameObject.tag == "Enemy2")
        {
            col.GetComponent<Physical_Script>().BlowUp();
        }
    }
}
