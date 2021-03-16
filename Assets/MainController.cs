using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    /*//private CharacterController _controller;
    private float playerSpeed = 2.0f;
    private Collider2D _collider;
    //private CollidingBehaviour _behaviour;
    private Vector3 _lastMove;

    // Start is called before the first frame update
    void Start()
    {
        GeneralScript.GameStart();
        _collider = gameObject.GetComponent<BoxCollider2D>();
        //_behaviour = gameObject.GetComponent<CollidingBehaviour>();
        Debug.Log(_collider);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        Vector3 moveAdjusted =  move * (Time.deltaTime * playerSpeed);
        /*if (_behaviour.isCollided) {
            gameObject.transform.position -= _lastMove;
        }
        else
        {
            _lastMove = moveAdjusted;
            gameObject.transform.position += moveAdjusted;
        //}
    }*/
}
