/*
 * Sarahi Murillo
 * DestroyOutOfBounds.cs
 * Challange 2 
 * When ball is out of bound, player takes damage. If dog goes out of bound, object is destroyed. 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float bottomBound = -1;
    public float leftBound = -10;

    // Update is called once per frame
    void Update()
    {
        // ball is out 
        if (transform.position.y < bottomBound)
        {            
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().TakeDamage();

            Destroy(gameObject);
        }
       
        if (transform.position.x < leftBound)
        { 
            Destroy(gameObject);
        }
    }
}
