using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovementRigidBody : MonoBehaviour
{
    private Rigidbody2D rb;
    private const float jumpVelocity = 10f;
    private const float horizontalVelocity = 5f;

    private PlayerCollision _collisionInfo;
    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        _collisionInfo = gameObject.GetComponent<PlayerCollision>();
        GeneralScript.GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(HorizontalMovement(), VerticalMovement());
    }
    float HorizontalMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            return -horizontalVelocity;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            return horizontalVelocity;
        }
        return 0;
    }

    float VerticalMovement()
    {
        if (_collisionInfo.IsGrounded() && Input.GetKeyDown(KeyCode.Space)) {
            return jumpVelocity;
        }
        return rb.velocity.y;
    }
        
}
