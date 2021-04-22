using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobMovement : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;
    public Rigidbody2D rb;

    private Vector2 moveDirection;

    public void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = player.transform.position.x - this.transform.position.x;
        float moveY = player.transform.position.y - this.transform.position.y;

        moveDirection = new Vector2(moveX, moveY).normalized;

    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    void Update()
    {
        ProcessInputs();
    }
}
