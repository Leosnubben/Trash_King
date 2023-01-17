using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayAudioOnTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource myAudioSource;
    [SerializeField] private AudioClip myAudioClip1;
    [SerializeField] private float volume = 1.0f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!CompareTag("Player"))
        {
            myAudioSource.Play();
            Debug.Log("Start playing");
        }

    }
   
}    
