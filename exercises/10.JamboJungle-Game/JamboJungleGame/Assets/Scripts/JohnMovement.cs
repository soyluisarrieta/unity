using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnMovement : MonoBehaviour
{
    public float Speed;
    public float JumpForce;

    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    private bool Grounded;

    void Start()
    {
        // Acceder al Rigidbody
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Conocer la tecla presionada (a: -1, d: 1, si no presiona nada: 0) 
        Horizontal = Input.GetAxisRaw("Horizontal");

        // Característica de salto sólo cuando toca el suelo
        if(Physics2D.Raycast(transform.position, Vector3.down, 0.1f))
        {
            Grounded = true;
        } else
        {
            Grounded = false;
        }

        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && Grounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);
    }
}
