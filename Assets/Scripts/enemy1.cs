using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    //Oscar
    float speed = 5;
    float spawnX;
    int direction = 1; // 1 = höger, 2 = vänster

    

    
    float timer;
    public void Start()
    {
        
        //Positionen enemyn är på när spelet börjar
        spawnX = transform.position.x; 

        
    }

    public void Update()
    {
        
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
            
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime; // Rör sig höger
        }
        if (direction == 2)
        {
           
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime; // Rör sig vänster
        }
        timer += Time.deltaTime; //Timer på när den ska ändra håll
        if (timer >= 0.7)
        {
           
            timer = 0;
        }
        
        
    }
  
}
