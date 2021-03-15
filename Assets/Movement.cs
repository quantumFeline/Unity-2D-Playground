using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector2 _constSpeed = new Vector2(3.4f, 3.4f);
    private Vector2 _currSpeed = new Vector2(0,0);

    private CharacterController controller;

    public Vector2 CurrSpeed { get => _currSpeed; set => _currSpeed = value; }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        //controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementVector = new Vector3(0,0,0);
        bool collided = gameObject.GetComponent<PlayerCollision>().Collided;

        if (gameObject.GetComponent<PlayerCollision>().Grounds > 0)
        {
            Debug.Log("Grounded");
            _currSpeed.y = Input.GetKeyDown(KeyCode.Space) ? _constSpeed.y : 0; // Ternary operator
        }
        else
        {
            _currSpeed.y += Physics.gravity.y * Time.deltaTime;
        }

        _currSpeed.x = Input.GetAxis("Horizontal") * _constSpeed.x;
        //_currSpeed.y = Input.GetAxis("Vertical") * _constSpeed.y;

        movementVector.y = CurrSpeed.y;
        movementVector.x = CurrSpeed.x;
        //controller.Move(movementVector * Time.deltaTime);
       gameObject.transform.position += movementVector * Time.deltaTime;
       // gameObject.transform.position += new Vector3(Time.deltaTime * speedX, 0, 0);
    }
}
