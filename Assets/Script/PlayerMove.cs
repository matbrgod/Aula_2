using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class PlayerMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //Global variables can be used in any method in this class

    SpriteRenderer spriteRenderer;//SpriteRenderer to change the player's sprite
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 moveDirection;
    

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("Are you sure this is a sprite?");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;

        //Check for collision after moving - 64 is the layer mask for the "Wall" layer (7th layer in Unity; 0 indexed)


    }
     void FixedUpdate()
        {
            // Movement
            rb.linearVelocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

        
        }
    }

