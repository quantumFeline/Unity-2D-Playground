using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered");
        Destroy(gameObject);
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerScore>().RaiseScore();
        }
    }
}
