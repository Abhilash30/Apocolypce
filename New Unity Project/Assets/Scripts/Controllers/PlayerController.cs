using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float checkRadius;
    public Transform checkGround;
    public LayerMask whatIsGround;
    public Rigidbody2D rb;
    
    private float moveInput;
    private bool isGrounded;

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(checkGround.position, checkRadius, whatIsGround);
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
}
