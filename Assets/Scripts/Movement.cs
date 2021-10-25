using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D rb;
    public bool canMove;

    Vector2 movement;
    private void Start()
    {
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if(canMove == true)
        {
            rb.MovePosition(rb.position + movement * movementSpeed * Time.deltaTime);
       }
    }
}
