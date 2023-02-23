using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Emanuil, När man trycker W, Space eller UpAroow så kommer det spelas ett ljud
public class PlayingAudioSource : MonoBehaviour
{
    [SerializeField] private AudioSource myAudioSource;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            myAudioSource.Play();
        }
    }
}
