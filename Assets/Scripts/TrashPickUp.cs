using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashPickUp : MonoBehaviour
{
    public int Score;
   
    
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        // Om spelaren kolliderar med n�got med "Trash" tagen s� f�rsvinner den och �kar score med 1
        if (collision.gameObject.tag == "Trash")
        {
            Destroy(collision.gameObject);
            Score++;

            transform.localScale += new Vector3(0.05f, 0.05f, 0 );

            
            
        }

    }   
}
