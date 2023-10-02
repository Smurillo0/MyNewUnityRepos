/*
 * Sarahi Murillo
 * Challenge 3
 * added a win and lose condition as well as a scene manager to reload screen when the key R is pressed.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManagerX : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    public PlayerControllerX playerControllerScript;


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
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();
        }

        scoreText.text = "Score: 0";

    }

    // Update is called once per frame
    void Update()
    {
        //Display score until gameover
        if (!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        //lose condition: if u collide on a bomb
        if (playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose!\nPress R to Try Again!";
        }


        // win condition
        if (score >= 30)
        {
            playerControllerScript.gameOver = true;
            won = true;

            scoreText.text = "You Win!\nPress R to Try Again!";
        }

        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
