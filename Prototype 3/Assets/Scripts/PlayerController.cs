/*
 * Sarahi Murillo
 * Project 3 
 * The player is able to press the space bar and jump while also keeping gravity anf jumpforce in mind 
   Also used a bool to know when the player hits the ground by using a collision function
 
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;
    public ForceMode jumpForceMode;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;
    
    // Start is called before the first frame update
    void Start()
    {
        //set reference variables to components
        rb = GetComponent<Rigidbody>();

        //Modify gravity
        Physics.gravity *= gravityModifier;
        
    }

    // Update is called once per frame
    void Update()
    {
        // press spacebar to jump 

        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, jumpForceMode);
            isOnGround = false;
        }
    }

    private void onCollisionEnter(Collision collison)
    {
        if(collison.gameObject.CompareTag("Ground"))
        {
            isOnGround = true; 
        }

    }
}
