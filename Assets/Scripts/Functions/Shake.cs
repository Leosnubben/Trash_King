using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    //Oscar
    public static bool start = false;
    public float duration = 1f;
    public AnimationCurve curve; 

    private void Update()
    {
        if (start) //När start blir true så startar den camerashaken, och sätter den på false
        {
            start = false;
            StartCoroutine(Shaking());
        }
        IEnumerator Shaking()
        {
            Vector3 startPosition = transform.position; 
            float elapsedTime = 0f;
            
            while (elapsedTime < duration)
            {
                elapsedTime += Time.deltaTime;
                float strength = curve.Evaluate(elapsedTime / duration); //En kurva för att bestämma hur mycket det skakar, 
                transform.position = startPosition + Random.insideUnitSphere * strength; //Gör så att den skakar i en "sphere" rörelse
                yield return null;
            }

            transform.position = startPosition;
        }
    }
}
