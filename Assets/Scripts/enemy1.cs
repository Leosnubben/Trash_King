using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    //Oscar
    float speed = 5;
    float spawnX;
    int direction = 1; // 1 = h�ger, 2 = v�nster

    Animator anim;

    
    float timer;
    public void Start()
    {
        anim = GetComponent<Animator>();
        //Positionen enemyn �r p� n�r spelet b�rjar
        spawnX = transform.position.x; 

        
    }

    public void Update()
    {
        anim.SetBool("Death", true);
        if (transform.position.x < spawnX - 1)
        {
            direction = 1;
        }
        if (transform.position.x > spawnX + 1)
        {
            direction = 2;
        }

        if (direction == 1)
        {
            
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime; // R�r sig h�ger
        }
        if (direction == 2)
        {
           
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime; // R�r sig v�nster
        }
        timer += Time.deltaTime; //Timer p� n�r den ska �ndra h�ll
        if (timer >= 0.7)
        {
           
            timer = 0;
        }
        
        
    }
  
}
