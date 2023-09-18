/*
 * Sarahi Murillo
 * DetectCollisions.cs
 * Prototype 2 Walkthrough 
 * detects collisions with the animal objects.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attatch to food projectile prefab

public class DetectCollisions : MonoBehaviour
{
    private DisplayScore displayScoreScript;

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }
    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
