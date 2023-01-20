using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    ///Hela koden skriven av Leo
    public float speed; 
    public float jump; //hopph�jd
    float moveVelocity; //Hastighet
    float Timer = 1f;
    int HP = 5; // Player har 3 HP
    Transform player;


    bool isGrounded = true;

    private void Start()
    {
        player = FindObjectOfType<TrashPickUp>().gameObject.transform;
    }
    IEnumerator OilSlip()
    {
        speed *= 10;

        yield return new WaitForSeconds(0.5f);

        speed /= 10;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Timer -= Time.deltaTime;
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
        if (collision.gameObject.tag == "Oil")
        {
            Timer -= Time.deltaTime;
            //  speed = speed * 10; 
            StartCoroutine(OilSlip());
            print ("Slippery!");
        }
        if (collision.gameObject.tag == "Enemy")
        {
            HP--; //-1 HP - Leo
            print("Ditt HP " + HP);
            Shake.start = true;
            
        }
        if (HP <= 0)
        {
            player.position = new Vector3(0, -4, 0);
            HP = 3;
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
