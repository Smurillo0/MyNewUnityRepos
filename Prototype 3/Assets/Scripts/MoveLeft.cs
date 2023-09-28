/*
 * Sarahi Murillo
 * Project 3 
 * Move objects to the left amd use if statement to destroy objects out off bounds.
 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    public float speed = 30f;
    private float leftBound = -15;


    // Update is called once per frame
    //changed to FixedUpdate so object doesn't go through character
    void FixedUpdate()
    {
        //    obj moves left 
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        //destroy obstacles out of bounds off screen to the left 
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
