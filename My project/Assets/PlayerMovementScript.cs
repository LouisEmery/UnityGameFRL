using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    Rigidbody2D body;
    float MoveSpeedLimiter = 0.7f;
    public float PlayerMovementSpeed;
    float horizontal;
    float vertical;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0)
        {
            horizontal *= MoveSpeedLimiter;
            vertical *= MoveSpeedLimiter;
        }
        body.velocity = new Vector2(horizontal * PlayerMovementSpeed, vertical * PlayerMovementSpeed);
    }
}
