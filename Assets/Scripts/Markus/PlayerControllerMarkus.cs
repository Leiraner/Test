using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerMarkus : MonoBehaviour
{

    Rigidbody2D rb;

    public float speed;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        //rb = FindObjectOfType<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
       // Jump();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        float moveByX = x * speed;
        float moveByY = y * speed;
       
        rb.velocity = new Vector2(moveByX, rb.velocity.y);
        rb.velocity = new Vector2(moveByY, rb.velocity.x);
    }

   /* void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
   */
}
