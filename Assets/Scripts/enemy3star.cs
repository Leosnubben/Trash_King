using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3star : MonoBehaviour
{
    public float  timer = 5f;
    public Transform star;

    Transform player;

    private void Start()
    {
        player = FindObjectOfType<TrashPickUp>().gameObject.transform;
    }


    public void Update()
    {
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
