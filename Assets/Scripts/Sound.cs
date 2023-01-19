using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
//Emanuil, Denna kod gör att all music har samma volym och fungerar
public class Sound
{

    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;

}
