using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public float multiplier = 1.5f;

    public GameObject pickupEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        print("Collision");
        if (other.CompareTag("Player"))
        {
            print("Spelare");
            Pickup(other);
        }
    }
 

    void Pickup(Collider2D player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        PlayerStats stats =player.GetComponent<PlayerStats>();
        stats.Health *= multiplier;

        Destroy (gameObject);
    }

}
