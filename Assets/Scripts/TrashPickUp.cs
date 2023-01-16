using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashPickUp : MonoBehaviour
{
    // Oscar
   
    
    void Start()
    {
        
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
            //F�rst�r skr�pet
            Destroy(collision.gameObject);
            
            //N�r spelaren har kolliderat med skr�p s�, �kar den storlek
            transform.localScale += new Vector3(0.05f, 0.05f, 0 );

            
            
        }

    }   
}
