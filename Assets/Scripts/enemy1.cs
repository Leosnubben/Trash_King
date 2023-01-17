using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    float speed = 5;
    float spawnX; // the x position where it starts
    int direction = 1; // 1 = right, 2 = left

    float timer;
    public void Start()
    {
        spawnX = transform.position.x; // saving the x position it starts in in spawnX

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
            
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime; // moving to the right
        }
        if (direction == 2)
        {
           
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        }
        timer += Time.deltaTime;
        if (timer >= 0.7)
        {
           
            timer = 0;
        }
    }
}
