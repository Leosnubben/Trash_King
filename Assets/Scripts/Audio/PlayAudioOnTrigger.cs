using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
// Emanuil, dena kod gör så att när man går genom en viss objekt som har en rigidbody och en colider spelas det ett ljud eller musik. 
public class PlayAudioOnTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource myAudioSource;
    [SerializeField] private AudioClip myAudioClip1;
    [SerializeField] private float volume = 1.0f;
  
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            myAudioSource.Play();
            Debug.Log("Start playing");
        }
       
        
    }
   
}    
