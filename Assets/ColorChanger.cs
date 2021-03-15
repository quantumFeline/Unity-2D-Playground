using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorChanger : MonoBehaviour
{
    //public GameObject obj;
    public Color sphereColor;
    private Renderer _objectRenderer;
    private float _x = 0;
    private float _step = (float)1.0 / 4096;
    private int _ticker = 0;
    private bool _reverse = false;

    // Start is called before the first frame update
    void Start()
    {

        _objectRenderer = gameObject.GetComponent<Renderer>();
        //obj = gameObject;
        Debug.Log("Hello, world!");
        Debug.Log(Color.blue.r + " "+ Color.blue.g + " " + Color.blue.b);
        Debug.Log(_objectRenderer.material.color);
        sphereColor = new Color(0, 0, 0);
    }

    void UpdateColour()
    {
        _ticker++;
        //if (_ticker % 100 != 0) return;
        
        if (_reverse) _x-= _step;
        else _x+= _step;

        if (_x == 0 || _x >= 1)
        {
            _reverse = !_reverse;
            //Debug.Log("_x: " + _x + " current colour: " + _objectRenderer.material.color);
        }
        //Debug.Log(_x + ": _x");
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.
        sphereColor = new Color(0, 0, _x);
        UpdateColour();
        _objectRenderer.material.color = sphereColor;
        //myRenderer = obj.GetComponent<MeshRenderer>();
        //myRenderer.enabled = !myRenderer.enabled;
        //Material newMaterial = new Material(myRenderer.material);
        //myRenderer.material.color = sphereColor;
    }
}
