using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    public float velocidadMovimiento;
    public float fuerzaSalto;
    private Rigidbody2D rb;

    public bool suelo;
    public LayerMask estoEsSuelo;

    private Collider2D col;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();

    }

    void Update()
    {
        suelo = Physics2D.IsTouchingLayers(col, estoEsSuelo);

        rb.velocity = new Vector2(velocidadMovimiento, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (suelo)
            {
                rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
            }
        }

    }
}
