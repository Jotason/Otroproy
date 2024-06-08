using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool enSuelo = true;
    private float fuerzasalto = 6f;
    private float tiempoSalto = 0.2f;
    private float tiempoUltimoSalto = 0f;
    private float velocidadMovimiento = 4f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && enSuelo && Time.time >= tiempoUltimoSalto + tiempoSalto)
        {
            rb.velocity = new Vector2(rb.velocity.x,
                                        fuerzasalto);

            enSuelo = false;
            tiempoUltimoSalto = Time.time;
        }
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        Vector2 movimiento = new Vector2 (movimientoHorizontal * velocidadMovimiento, rb.velocity.y);
        rb.velocity = movimiento;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        enSuelo = true;
    }
}
