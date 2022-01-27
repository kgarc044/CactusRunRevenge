using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float movementSpeed;
    public float jumpForce;

    private Rigidbody2D playerRB;

    public bool grounded;
    public LayerMask whatisGround;

    public Collider2D playerCollider;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
        grounded = Physics2D.IsTouchingLayers(playerCollider, whatisGround);
        playerRB.velocity = new Vector2(movementSpeed, playerRB.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(grounded)
            {
                Jump();
            }

        }
    }

    void Jump()
    {
        playerRB.velocity = new Vector2(playerRB.velocity.x, jumpForce);
    }
}
