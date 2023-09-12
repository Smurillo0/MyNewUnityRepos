/*
		 * Sarahi Murillo
		 * TriggerZoneAddScoreOnce
		 * Prototype 1
		 * It adds a point to ScoreManager any time you collide a trigger point. 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;

        }

    }
 
}
