using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3star : MonoBehaviour
{
    //Oscar
    public float  timer = 5f;
    public Transform star;

    Transform player;
    
    private void Start()
    {
        //Referens för spelaren
        player = FindObjectOfType<TrashPickUp>().gameObject.transform;
    }


    public void Update()
    {
        //Timer för att spawna stjärnorna, om timern är över 0 så minskas den, När timern = 0, spawnar stjärnan
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else 
        {
            timer = 5f;
            Instantiate(star, player.position + new Vector3(0, 10, 0), Quaternion.identity);
        }
        


    }
   

}
