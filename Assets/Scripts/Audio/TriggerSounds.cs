using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSounds : MonoBehaviour
{
    //Skrivet av Leo
    /// <summary>
    /// Denna kod anv�ndes aldrig - Leo
    /// </summary>
    AudioSource source;

    [SerializeField]
    AudioClip SoundOne;
    [SerializeField]
    AudioClip SoundTwo;
    [SerializeField]
    AudioClip SoundThree;   //S� man kan v�lja vad f�r ljud som ska spelas - Leo
    private void Start()
    {
        source = GetComponent<AudioSource>();  //G�r s� man spelar ljudet ur en audio source - Leo
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
    }   //Man v�ljer vad f�r ljud och s� spelar den ljudet n�r man trycker p� respektive knapp - Leo
}
