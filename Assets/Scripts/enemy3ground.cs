using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3ground : MonoBehaviour
{
    //Oscar
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //Om denna enemy nuddar allting så går den sönder
        if(collision != null)
        {
            Destroy(this.gameObject);
        }

        
        
    }
}
