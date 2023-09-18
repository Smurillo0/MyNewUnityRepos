/*
 * Sarahi Murillo
 * DestroyOutOfBounds.cs
 * Prototype 2 Walkthrough
 * When the Animal objects or food object leaves frame it is destroyed.  
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;
   
    // Update is called once per frame
    void Update()
    {
        //Food out of bounds 
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //Animal out of bounds 
        if(transform.position.z < bottomBound)
        {
            //Debug.Log("Game Over!");

            //grab the health system script and call TakeDown()
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().TakeDamage();

            

            Destroy(gameObject);
        }
    }
}
