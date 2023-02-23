using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSounds : MonoBehaviour
{
    //Skrivet av Leo
    /// <summary>
    /// Denna kod användes aldrig - Leo
    /// </summary>
    AudioSource source;

    [SerializeField]
    AudioClip SoundOne;
    [SerializeField]
    AudioClip SoundTwo;
    [SerializeField]
    AudioClip SoundThree;   //Så man kan välja vad för ljud som ska spelas - Leo
    private void Start()
    {
        source = GetComponent<AudioSource>();  //Gör så man spelar ljudet ur en audio source - Leo
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            source.PlayOneShot(SoundOne);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            source.PlayOneShot(SoundTwo);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            source.PlayOneShot(SoundThree);
        }
    }   //Man väljer vad för ljud och så spelar den ljudet när man trycker på respektive knapp - Leo
}
