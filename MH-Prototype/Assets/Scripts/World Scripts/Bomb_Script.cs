using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_Script : MonoBehaviour
{
    [SerializeField] GameObject hori;
    [SerializeField] GameObject verti;
    public Color flash;
    public Color normal;
    public float waitTime;
    private SpriteRenderer rend;
    public bool start = true;

    void OnTriggerEnter2D(Collider2D col)
    {
        rend = GetComponent<SpriteRenderer>();
        //print(col);
        if (col.gameObject.tag == "Ally" && start)
        {
            //print("blow");
            StartCoroutine(Blow());
        }
    }

    IEnumerator Blow()
    {
        start = false;
        bool alt = false;
        for (float i = 0; i <= 3; i += 0.5f)
        {
            hori.transform.localScale = new Vector3(i, 0.5f, 0);
            verti.transform.localScale = new Vector3(0.5f, i, 0);

            if (alt) 
            {
                rend.color = normal;
                alt = false;
            }
            else
            {
                rend.color = flash;
                alt = true;
            }

            yield return new WaitForSeconds(0.1f);
            if (i == 3)
            {
                hori.transform.localScale = new Vector3(30, 0.5f, 0);
                verti.transform.localScale = new Vector3(0.5f, 30, 0);
            }
        }

        yield return new WaitForSeconds(0.5f);

        Destroy(this.gameObject);
    }
}
