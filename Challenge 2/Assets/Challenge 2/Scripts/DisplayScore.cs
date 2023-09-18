/*
 * Sarahi Murillo
 * DisplayScore.cs
 * Challange 2 
 * Add score and disply it on the screen
 
 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisplayScore : MonoBehaviour
{   
    public Text textbox;

    //win condition 
    public static bool won = false;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";

        won = false;
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;

        if(score >= 5)
        {
            won = true;

            textbox.text = "You win!\nPress R to Try Again";
           
        }
    }


}
