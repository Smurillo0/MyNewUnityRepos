/*
		 * Sarahi Murillo
		 * CamFollowPlayer.cs
		 * Prototype 1 
		 * Boolean function that has a condition if you collide with triggerzones then it adds to the score (ScoreManager) 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attatch this to the player 
public class PlayerEnterTrigger : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }




    }
}
