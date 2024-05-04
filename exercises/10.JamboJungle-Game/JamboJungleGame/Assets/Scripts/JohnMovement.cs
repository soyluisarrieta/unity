using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnMovement : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    private float Horizontal;

    void Start()
    {
        // Acceder al Rigidbody
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Conocer la tecla presionada (a: -1, d: 1, si no presiona nada: 0) 
        Horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);
    }
}
