
/*
		 * Sarahi Murillo
		 * LossOnFall.cs
		 * Prototype1
		 * If the vehicle falls from the road, they lose.
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnFall : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1)
        {
            ScoreManager.gameOver = true;

        }
    }
}
