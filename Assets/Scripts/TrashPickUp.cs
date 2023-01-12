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


        if (collision.gameObject.tag == "Trash")
        {
            Destroy(collision.gameObject);
            Score++;

        }

    }   
}
