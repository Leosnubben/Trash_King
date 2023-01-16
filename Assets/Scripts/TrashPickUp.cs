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

        // Om spelaren kolliderar med något med "Trash" tagen så försvinner den och ökar score med 1
        if (collision.gameObject.tag == "Trash")
        {
            //Förstör skräpet
            Destroy(collision.gameObject);
            
            //När spelaren har kolliderat med skräp så, ökar den storlek
            transform.localScale += new Vector3(0.05f, 0.05f, 0 );

            
            
        }

    }   
}
