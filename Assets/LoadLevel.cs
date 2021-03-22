using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public  void Start()
    {
        Debug.Log("Gravity changed");
        Physics2D.gravity = Vector2.up * Physics2D.gravity.magnitude;
        var players = GameObject.FindGameObjectsWithTag("Player");
        foreach (var player in players)
        {
            player.GetComponent<MovementRigidBody>().jumpVelocity = - Physics2D.gravity.y;
            Debug.Log("Gravity changed for " + player.name);
        }
    }
}