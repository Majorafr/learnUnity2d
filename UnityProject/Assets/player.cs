using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D MyrigidBody;
    private bool flipSprite;
    private SpriteRenderer spritePlayer;
    // Start is called before the first frame update
    void Start()
    {
        MyrigidBody = GetComponent<Rigidbody2D>();
        flipSprite = false;
        spritePlayer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        

        HandleMovement(horizontal);
        if (horizontal > 0)
        {
            spritePlayer.flipX = true;
        }
        else spritePlayer.flipX = false;
    }

    private void HandleMovement(float horizontal)
    {
        MyrigidBody.velocity = new Vector2(horizontal * playerSpeed, MyrigidBody.velocity.y);
    }
    


}   
