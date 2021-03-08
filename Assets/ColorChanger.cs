using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorChanger : MonoBehaviour
{
    //public GameObject obj;
    public Color sphereColor;
    private Renderer _objectRenderer;
    private int _x = 0;

    // Start is called before the first frame update
    void Start()
    {

        _objectRenderer = gameObject.GetComponent<Renderer>();
        //obj = gameObject;
        Debug.Log("Hello, world!");
        sphereColor = new Color(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.
        sphereColor = new Color(0, 0, (int)(_x/100));
        _x++;
        _objectRenderer.material.color = sphereColor;
        //myRenderer = obj.GetComponent<MeshRenderer>();
        //myRenderer.enabled = !myRenderer.enabled;
        //Material newMaterial = new Material(myRenderer.material);
        //myRenderer.material.color = sphereColor;
    }
}
