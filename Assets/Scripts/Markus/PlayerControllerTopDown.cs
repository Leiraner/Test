using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTopDown : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D rb;

    Vector2 movement;

    void Update()

    {
        MovementInput();
    }
    private void FixedUpdate()
    {
        rb.velocity = movement * moveSpeed;
    }
    
    void MovementInput()
    {
            float nx = Input.GetAxisRaw("Horizontal");
            float ny = Input.GetAxisRaw("Vertical");
             //normalized verhindert dass man sich diagonal schneller bewegt als auf der x oder y Achse
            movement = new Vector2(nx, ny).normalized;
    }
    
}
