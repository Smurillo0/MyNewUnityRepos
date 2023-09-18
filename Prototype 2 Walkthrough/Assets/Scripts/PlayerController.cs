/*
    *Sarahi Murillo
    *PlayerController.cs
    *Prototype 2 Walkthrough
    *Makes player move left/right using arrow keys or A/D keys while also keeping player in bounds. 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 14;

    // Update is called once per frame
    void Update()
    {
        // get input from arrow keys or A/D keys
        horizontalInput = Input.GetAxis("Horizontal");

        // transform horizontally with inputs
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Keep player in bounds
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
