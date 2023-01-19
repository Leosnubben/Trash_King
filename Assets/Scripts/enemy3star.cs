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
        //Referens f�r spelaren
        player = FindObjectOfType<TrashPickUp>().gameObject.transform;
    }


    public void Update()
    {
        //Timer f�r att spawna stj�rnorna, om timern �r �ver 0 s� minskas den, N�r timern = 0, spawnar stj�rnan
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
