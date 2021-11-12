using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava_Script : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D col)
    {
        //print(col.gameObject.tag);
        if (col.gameObject.tag == "Ally")
        {
            if (col.gameObject.GetComponent<Ally_Script>() != null)
            {
                col.gameObject.GetComponent<Ally_Script>().Damage();
            }
            else if (col.gameObject.GetComponent<Ally2_Script>() != null)
            {
                col.gameObject.GetComponent<Ally2_Script>().Damage();
            }
        }
    }
}
