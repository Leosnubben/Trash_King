using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1hitbox : MonoBehaviour
{
    //Oscar
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Om spelaren nuddar hitboxen så dör enemyn
            Destroy(this.transform.parent.gameObject);

            




        }
    }
}
