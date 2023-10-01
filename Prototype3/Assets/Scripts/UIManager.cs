﻿/*
 * Sarahi Murillo
 * Prototype 3
 * displays the score on the screen and counts
 * win/loss conditions 
 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    public PlayerController playerControllerScript;

    public bool won = false;
    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }
        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }

        scoreText.text = "Score: 0";
    }
    // Update is called once per frame
    void Update()
    {
            //display score untill game over
        if(!playerControllerScript.gameOver)
        {
                scoreText.text = "Score: " + score;

        }

        //loss condition: collide w/ obstacle
        if(playerControllerScript.gameOver && !won)
        {
          scoreText.text = "You Lose!\nPress R to Try Again!";
        }

        //win condition : 10pts
        if(score >= 10)
        {
          playerControllerScript.gameOver = true;
           won = true;


           scoreText.text = "You Win!\nPress R to Try Again!";
        }

        if(playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
