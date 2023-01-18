using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3ground : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision != null)
        {
            Destroy(this.gameObject);
        }

        
        
    }
}
