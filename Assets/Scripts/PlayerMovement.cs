using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    ///Hela koden skriven av Leo och lite Ella 
    public Animator animatior;
    public float speed; 
    public float jump; //hopphöjd
    float moveVelocity; //Hastighet
    float Timer = 1f;
    int HP = 5; // Player har 3 HP
    
    
    bool isGrounded = true;
    public void Update()
    {
        Movement();
        Animation();
    }
    IEnumerator OilSlip()
    {
        speed *= 10;

        yield return new WaitForSeconds(0.5f);

        speed /= 10;

    }
  void Animation()
        //Ella
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            animatior.SetBool("Walk", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            animatior.SetBool("Walk", false);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            animatior.SetBool("Walk2", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            animatior.SetBool("Walk2", false);
        }
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
            Destroy(gameObject);
            SceneManager.LoadScene("Meny(Edwin)");
        }
    }


    void Movement()
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
