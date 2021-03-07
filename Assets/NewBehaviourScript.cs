using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    //public GameObject obj;
    public Color sphereColor;
    //private MeshRenderer myRenderer;
    private int _x = 0;
     
    // Start is called before the first frame update
    void Start()
    {

        //obj = gameObject;
        Debug.Log("Hello, world!");
        sphereColor = new Color(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        sphereColor = new Color(0, 0, (int)(_x/100));
        _x++;
        gameObject.GetComponent<Renderer>().material.color = sphereColor;
        //myRenderer = obj.GetComponent<MeshRenderer>();
        //myRenderer.enabled = !myRenderer.enabled;
        //Material newMaterial = new Material(myRenderer.material);
        //myRenderer.material.color = sphereColor;
    }
}
