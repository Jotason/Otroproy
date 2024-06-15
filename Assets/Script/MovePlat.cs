using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlat : MonoBehaviour
{
    public Transform[] potiPlata;
    public float velociPlata = 0;
    private int nextPlata = 1; 
    private bool orderPlata = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (orderPlata && nextPlata + 1 >= potiPlata.Length)
        {
            orderPlata = false;
        }
        if (!orderPlata && nextPlata <= 0) {
            orderPlata = true;
        }

        if (Vector2.Distance(transform.position, potiPlata[nextPlata].position) < 0.1f)
        {
            if (orderPlata)
            {
                nextPlata += 1;
            }
            else { 
            nextPlata -= 1;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, potiPlata[nextPlata].position, velociPlata * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(this.transform);   
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }

    }
}
