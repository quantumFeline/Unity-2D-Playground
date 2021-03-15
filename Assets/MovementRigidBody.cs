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
    }

    // Update is called once per frame
    void Update()
    {
        if (_collisionInfo.Grounds > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpVelocity;
        }
        HorizontalMovement();
    }
    void HorizontalMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-horizontalVelocity, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(horizontalVelocity, rb.velocity.y);
        }
        else
        {
            if(_collisionInfo.Grounds > 0)
            {
                rb.velocity = new Vector2(0, rb.velocity.y);
            }         
        }
    }
        
}
