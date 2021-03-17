using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private bool collided = false;
    private Collider2D _collider;
    private int grounds = 0;

    private void Start()
    {
        _collider = gameObject.GetComponent<Collider2D>();
    }

    public bool Collided { get => collided; }
    public int Grounds { get => grounds; }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Collision! " + n);
        collided = true;
        if (collision.rigidbody.gameObject.CompareTag("Floor"))
        {
            grounds++;
           // var curSpeed = gameObject.GetComponent<Movement>().CurrSpeed;
        }
        //gameObject.transform.position -=  new Vector3(curSpeed.x, curSpeed.y, 0) * Time.deltaTime;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //Debug.Log("Collision exit");
        collided = false;
        if (collision.rigidbody.gameObject.CompareTag("Floor"))
        {
            grounds--;
        }
    }

    public bool IsGrounded()
    {
        var hit = new RaycastHit2D[2];
        var height = _collider.bounds.size.y;
        var center = gameObject.transform.position;
        var bottom = center - new Vector3(0, height / 2f, 0);
        var dist = 0.2f;
        var hitN = Physics2D.Raycast(bottom, Vector2.down, new ContactFilter2D().NoFilter(), hit, dist);
        Debug.DrawRay(bottom, Vector3.down * dist, Color.yellow, 3);
        //Debug.Log(hitN);
        return hitN != 0;
        //Debug.Log("hit info: " + hit + " " + hit[0].collider + " " + hit[1].collider);
        // if (hit[1].collider == null) return false;
        //
        // Debug.Log("Ground: " + hit[1].collider.gameObject.name);
        // return true;

    }
}
