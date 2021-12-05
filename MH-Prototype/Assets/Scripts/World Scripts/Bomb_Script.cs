using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_Script : MonoBehaviour
{
    [SerializeField] GameObject hori;
    [SerializeField] GameObject verti;
    public float waitTime;

    void OnTriggerEnter2D(Collider2D col)
    {
        //print(col);
        if(col.gameObject.tag == "Ally")
        {
            print("blow");
            Blow();
        }
    }

    private void Blow()
    {
        for (float i = 3; i >= 0; i -= 0.5f)
        {
            hori.transform.localScale = new Vector3(i, 0.5f, 0);
            hori.transform.localScale = new Vector3(0.5f, i, 0);

            float counter = 0;

            while (counter < waitTime)
            {
                //Increment Timer until counter >= waitTime
                counter += Time.deltaTime;
            }
        }
    }
}
