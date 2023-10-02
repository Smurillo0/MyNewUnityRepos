/*
 * Sarahi Murillo
 * Challenge 3 
 * detect collision with money and add one to the score
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AddScore : MonoBehaviour
{
    private UIManagerX uIManager;

    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManagerX>();

    }

    private void OnTriggerEnter(Collider other)
    { 
            uIManager.score++;
      

    }
}
