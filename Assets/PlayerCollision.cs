using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private bool collided = false;
    private int grounds = 0;

    public bool Collided { get => collided; }
    public int Grounds { get => grounds; }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Collision! " + n);
        collided = true;
        if (collision.rigidbody.gameObject.CompareTag("Floor"))
        {
            grounds++;
        }
        var curSpeed = gameObject.GetComponent<Movement>().CurrSpeed;
        //gameObject.transform.position -=  new Vector3(curSpeed.x, curSpeed.y, 0) * Time.deltaTime;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Collision exit");
        collided = false;
        if (collision.rigidbody.gameObject.CompareTag("Floor"))
        {
            grounds--;
        }
    }
}
