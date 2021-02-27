using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidBody;
    [SerializeField] float timeToWait = 05f;

    //Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;

        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
           
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
       
       
    }
}
