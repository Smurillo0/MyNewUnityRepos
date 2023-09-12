/*
		 * Sarahi Murillo
		 * CamFollowPlayer.cs
		 * Prototype 1 
		 * Camera follows the player. Using the offset and player object we use the udpate fucntion to allow the camera to follow the player.

 */

using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -10);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
