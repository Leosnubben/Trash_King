using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3ground : MonoBehaviour
{
    //Oscar
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //Om denna enemy nuddar allting s� g�r den s�nder
        if(collision != null)
        {
            Destroy(this.gameObject);
        }

        
        
    }
}
