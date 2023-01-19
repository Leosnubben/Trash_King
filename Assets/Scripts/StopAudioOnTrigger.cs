using UnityEngine;
using UnityEngine.Events;
//Emanuil, denna kod g�r s� att n�r man g�r genom en viss objekt som har en rigidbody och en colider stoppas det ett ljud eller musik.  
public class StopAudioOnTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource myAudioSource;
    [SerializeField] private AudioClip myAudioClip1;
    [SerializeField] private float volume = 1.0f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            Invoke("PauseMusic", 0.5f);
        }

    }

    void PauseMusic()
    {
        myAudioSource.Pause();
        Debug.Log("Stop playing");
    }

}
