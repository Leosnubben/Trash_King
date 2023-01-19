using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1hitbox : MonoBehaviour
{
    //Oscar
    Animator anim;
    private void Start()
    {
        
        anim = GetComponentInParent<Animator>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Om spelaren nuddar hitboxen s� d�r enemyn
            anim.SetBool("Death", true);
            Destroy(this.transform.parent.gameObject,1);

            




        }
    }
}
