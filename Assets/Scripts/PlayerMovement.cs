using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Movement - Leo
    public float speed;
    public float jump;
    float moveVelocity;
    float Timer = 1f;

    bool isGrounded = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Timer -= Time.deltaTime;
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
        if (collision.gameObject.tag == "Oil")
        {
            speed = speed * 10;
            print ("Slippery!");
        }
    }
    void Update()
    {
        //Jumping - Leo
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W))
        {
            if (isGrounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
                isGrounded = false;
            }        
        }
         moveVelocity = 0;

        //Left Right Movement - Leo
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

    }
    //Check if Grounded - Leo
    void OnTriggerEnter2D()
    {
        isGrounded = true;
    }

    void React()
    {
        if (Input.GetKey(KeyCode.R))
        {
            transform.position = new Vector2(0, 1);
            print("Teleport!");
        }
    }
          
}
