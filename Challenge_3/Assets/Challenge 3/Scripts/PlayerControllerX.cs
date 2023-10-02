/*
 * Sarahi Murillo
 * Challenge3
 * assigned RigidBody variable (playerRb) using the GetComponent()
 * added a bool to keep ballon from going beyond upperboundry.
 * added a else if statement in OnCollisionEnter function to test if the ballon touches the ground then it bounces back up using .AddForce()

 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver;

    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;

    //check of ballon is low enough. only go up if true
    public bool isLowEnough;
    private double upperbound = 14.7;


    // Start is called before the first frame update
    void Start()
    {
        // assign RigidBody variable
        playerRb = GetComponent<Rigidbody>();

        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > upperbound)
        {
            isLowEnough = false;
        }
        else
        {
            isLowEnough = true;
        }
    // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && isLowEnough && !gameOver)
        {
          playerRb.AddForce(Vector3.up * floatForce);
            
        }
        if (transform.position.y > upperbound)
        {
            isLowEnough = false;
        }
        else
        {
            isLowEnough = true;
        }




    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        }

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }
        //when collide when the ground bounce back up
        else if (other.gameObject.CompareTag("Ground") && !gameOver)
        {
            playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }
}
